const PORT = process.env.PORT || 5000;
const express = require('express');
const app = express();

const http = require('http');
const server = http.Server(app);

app.use(express.static('src'));

server.listen(PORT, function() {
  console.log('Chat server running');
});

const io = require('socket.io')(server);

io.on('connection', function(socket) {
  socket.on('message', function(msg) {
    io.emit('message', msg);
  });
});