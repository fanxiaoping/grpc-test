var grpc = require('grpc');
var messages = require('./proto/helloworld/helloworld_pb.js');
var services = require('./proto/helloworld/helloworld_grpc_pb.js')

var request = new messages.HelloRequest();
request.setName('world');

var client = new services.GreeterClient(
    'localhost:50001',
    grpc.credentials.createInsecure()
);
client.sayHello(request, function(err,data){
    if(err){
        console.error(err);
    }
    console.log(data);
})