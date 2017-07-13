var app = require('express')();
var http = require('http').createServer(app);
var io = require('socket.io')(http);


app.get('/', function(req, res){
  res.sendFile(__dirname + '/index.html');
});
http.listen(3000,function(){
	console.log('server start:3000');
});
io.on('connection', function(socket){
	console.log('connect '+(socket.id).toString());
	 io.send('send data','your id'+(socket.id).toString());
  socket.on('disconnect',function(){
    console.log('disconnect '+(socket.id).toString());
    });
	
  socket.on('send data', function(msg){
    io.emit('send data', msg);
      console.log(msg);
  });
  
});







