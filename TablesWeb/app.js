const http = require('http');
const url=require('url');

const hostname = '127.0.0.1';
const port = 8080;

const server=http.createServer(function(req,res){
  res.statusCode = 200;
  var pathname=url.parse(req.url).pathname;
  switch(pathname){
      case '/admin':
          res.end('admin');
          doc = fs.readFile(__dirname + '/pages/admin.html', fsCallback);
      break;
      default:
          res.end('default');
          doc = fs.readFile(__dirname + '/pages/main.html', fsCallback);
      break;
  }
});

server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});