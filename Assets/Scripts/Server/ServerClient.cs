using System;
using BestHTTP.SocketIO;
using UnityEngine;

namespace Assets.Scripts.Server
{
    public class ServerClient : MonoBehaviour
    {
        public Action<Data> OnReceiveData { get; set; }

        private SocketManager _manager;


        private void Start()
        {
            _manager = new SocketManager(new Uri("http://localhost:3000//socket.io/"));
            _manager.Socket.On("send data", OnSendData);
        }
    
        void OnDestroy()
        {
            _manager.Close();
        }

        public void OnSendData(Socket soket, Packet packet, params object[] args)
        {
            Debug.Log(args[0]);
            string json = args[0].ToString();
            Data data = JsonUtility.FromJson<Data>(json);
            if (OnReceiveData != null)
            {
                OnReceiveData.Invoke(data);
            }
            else
            {
                Debug.Log("Data can't be received cause action was not created yet.");
            }
        }


        public void SendData(Data data)
        {
            string json = JsonUtility.ToJson(data);
            _manager.Socket.Emit("send data", json);
        }

    }
}