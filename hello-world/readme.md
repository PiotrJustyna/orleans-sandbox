# client stats

## 10K requests

```
info: Orleans.Runtime.ClientLogStatistics[100704]
      Statistics: ^^^
      App.Requests.Latency.Average.Millis=116.000
      App.Requests.LatencyHistogram.Millis=[3.2768:6.5535]=1, [6.5536:13.1071]=4, [13.1072:26.2143]=54, [52.4288:104.8575]=2384, [104.8576:209.7151]=7559, 
      App.Requests.TimedOut.Current=0
      App.Requests.Total.Requests.Current=10002
      Client.ConnectedGatewayCount=0
      Gateway.ConnectedClients.Current=0
      Messaging.Expired.AtDispatch.Current=0
      Messaging.Expired.AtInvoke.Current=0
      Messaging.Expired.AtReceive.Current=0
      Messaging.Expired.AtRespond.Current=0
      Messaging.Expired.AtSend.Current=0
      Messaging.Received.BatchSize.PerSocketDirection.ClientToGateway=1.000
      Messaging.Received.BatchSize.PerSocketDirection.GatewayToClient=0.000
      Messaging.Received.BatchSize.PerSocketDirection.SiloToSilo=0.000
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.ClientToGateway=[128:255]=10001, [1024:2047]=1, 
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.GatewayToClient=
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.SiloToSilo=
      Messaging.Received.Bytes.Header.Current=1580300
      Messaging.Received.Bytes.Total.Current=2161924
      Messaging.Received.Direction.OneWay.Current=0
      Messaging.Received.Direction.Request.Current=0
      Messaging.Received.Direction.Response.Current=10002
      Messaging.Received.Messages.From.S127.0.0.1:30000:0.Current=10002
      Messaging.Received.Messages.Total.Current=10002
      Messaging.Received.MessageSizeHistogram.Bytes=[128:255]=10001, [1024:2047]=1, 
      Messaging.Rerouted.OneWay.Current=0
      Messaging.Rerouted.Request.Current=0
      Messaging.Rerouted.Response.Current=0
      Messaging.Sent.BatchSize.PerSocketDirection.ClientToGateway=1.000
      Messaging.Sent.BatchSize.PerSocketDirection.GatewayToClient=0.000
      Messaging.Sent.BatchSize.PerSocketDirection.SiloToSilo=0.000
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.ClientToGateway=[128:255]=10002, 
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.GatewayToClient=
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.SiloToSilo=
      Messaging.Sent.Bytes.Header.Current=1300300
      Messaging.Sent.Bytes.Total.Current=1750357
      Messaging.Sent.Direction.OneWay.Current=0
      Messaging.Sent.Direction.Request.Current=10002
      Messaging.Sent.Direction.Response.Current=0
      Messaging.Sent.LocalMessages.Current=0
      Messaging.Sent.Messages.To.S127.0.0.1:30000:0.Current=10002
      Messaging.Sent.Messages.Total.Current=10002
      Messaging.Sent.MessageSizeHistogram.Bytes=[128:255]=10002, 
      Networking.Sockets.ClientToGateway.Closed.Current=1
      Networking.Sockets.ClientToGateway.Opened.Current=1
      Networking.Sockets.GatewayToClient.Closed.Current=0
      Networking.Sockets.GatewayToClient.Opened.Current=0
      Networking.Sockets.Silo.Closed.Current=0
      Networking.Sockets.Silo.Opened.Current=0
      Serialization.BufferPool.AllocatedBuffers.Current=250
      Serialization.BufferPool.BuffersInPool=250
      Serialization.BufferPool.CheckedInBuffers.Current=250
      Serialization.BufferPool.CheckedOutBuffers.Current=250
      Serialization.BufferPool.DroppedBuffers.Current=0
      Serialization.BufferPool.DroppedTooLargeBuffers.Current=0
      Serialization.BufferPool.InUse.AllocatedAndNotInPool_Buffers=0
      Serialization.BufferPool.InUse.CheckedOutAndNotCheckedIn_Buffers=0
```

## 100K requests

```
info: Orleans.Runtime.ClientLogStatistics[100704]
      Statistics: ^^^
      App.Requests.Latency.Average.Millis=772.000
      App.Requests.LatencyHistogram.Millis=[3.2768:6.5535]=1, [6.5536:13.1071]=59, [26.2144:52.4287]=955, [52.4288:104.8575]=4929, [104.8576:209.7151]=3082, [209.7152:419.4303]=12509, [419.4304:838.8607]=37838, [838.8608:1677.7215]=40629, 
      App.Requests.TimedOut.Current=0
      App.Requests.Total.Requests.Current=100002
      Client.ConnectedGatewayCount=0
      Gateway.ConnectedClients.Current=0
      Messaging.Expired.AtDispatch.Current=0
      Messaging.Expired.AtInvoke.Current=0
      Messaging.Expired.AtReceive.Current=0
      Messaging.Expired.AtRespond.Current=0
      Messaging.Expired.AtSend.Current=0
      Messaging.Received.BatchSize.PerSocketDirection.ClientToGateway=1.000
      Messaging.Received.BatchSize.PerSocketDirection.GatewayToClient=0.000
      Messaging.Received.BatchSize.PerSocketDirection.SiloToSilo=0.000
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.ClientToGateway=[128:255]=100001, [1024:2047]=1, 
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.GatewayToClient=
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.SiloToSilo=
      Messaging.Received.Bytes.Header.Current=15800300
      Messaging.Received.Bytes.Total.Current=21601924
      Messaging.Received.Direction.OneWay.Current=0
      Messaging.Received.Direction.Request.Current=0
      Messaging.Received.Direction.Response.Current=100002
      Messaging.Received.Messages.From.S127.0.0.1:30000:0.Current=100002
      Messaging.Received.Messages.Total.Current=100002
      Messaging.Received.MessageSizeHistogram.Bytes=[128:255]=100001, [1024:2047]=1, 
      Messaging.Rerouted.OneWay.Current=0
      Messaging.Rerouted.Request.Current=0
      Messaging.Rerouted.Response.Current=0
      Messaging.Sent.BatchSize.PerSocketDirection.ClientToGateway=1.000
      Messaging.Sent.BatchSize.PerSocketDirection.GatewayToClient=0.000
      Messaging.Sent.BatchSize.PerSocketDirection.SiloToSilo=0.000
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.ClientToGateway=[128:255]=100002, 
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.GatewayToClient=
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.SiloToSilo=
      Messaging.Sent.Bytes.Header.Current=13000300
      Messaging.Sent.Bytes.Total.Current=17500357
      Messaging.Sent.Direction.OneWay.Current=0
      Messaging.Sent.Direction.Request.Current=100002
      Messaging.Sent.Direction.Response.Current=0
      Messaging.Sent.LocalMessages.Current=0
      Messaging.Sent.Messages.To.S127.0.0.1:30000:0.Current=100002
      Messaging.Sent.Messages.Total.Current=100002
      Messaging.Sent.MessageSizeHistogram.Bytes=[128:255]=100002, 
      Networking.Sockets.ClientToGateway.Closed.Current=1
      Networking.Sockets.ClientToGateway.Opened.Current=1
      Networking.Sockets.GatewayToClient.Closed.Current=0
      Networking.Sockets.GatewayToClient.Opened.Current=0
      Networking.Sockets.Silo.Closed.Current=0
      Networking.Sockets.Silo.Opened.Current=0
      Serialization.BufferPool.AllocatedBuffers.Current=250
      Serialization.BufferPool.BuffersInPool=250
      Serialization.BufferPool.CheckedInBuffers.Current=250
      Serialization.BufferPool.CheckedOutBuffers.Current=250
      Serialization.BufferPool.DroppedBuffers.Current=0
      Serialization.BufferPool.DroppedTooLargeBuffers.Current=0
      Serialization.BufferPool.InUse.AllocatedAndNotInPool_Buffers=0
      Serialization.BufferPool.InUse.CheckedOutAndNotCheckedIn_Buffers=0
```

## 1M requests

```
info: Orleans.Runtime.ClientLogStatistics[100704]
      Statistics: ^^^
      App.Requests.Latency.Average.Millis=7914.000
      App.Requests.LatencyHistogram.Millis=[3.2768:6.5535]=1, [6.5536:13.1071]=16, [13.1072:26.2143]=36, [26.2144:52.4287]=183, [52.4288:104.8575]=2109, [104.8576:209.7151]=4436, [209.7152:419.4303]=10363, [419.4304:838.8607]=20867, [838.8608:1677.7215]=51155, [1677.7216:3355.4431]=139298, [3355.4432:6710.8863]=207047, [6710.8864:13421.7727]=422522, [13421.7728:26843.5455]=141969, 
      App.Requests.TimedOut.Current=0
      App.Requests.Total.Requests.Current=1000002
      Client.ConnectedGatewayCount=0
      Gateway.ConnectedClients.Current=0
      Messaging.Expired.AtDispatch.Current=0
      Messaging.Expired.AtInvoke.Current=0
      Messaging.Expired.AtReceive.Current=0
      Messaging.Expired.AtRespond.Current=0
      Messaging.Expired.AtSend.Current=0
      Messaging.Received.BatchSize.PerSocketDirection.ClientToGateway=1.000
      Messaging.Received.BatchSize.PerSocketDirection.GatewayToClient=0.000
      Messaging.Received.BatchSize.PerSocketDirection.SiloToSilo=0.000
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.ClientToGateway=[128:255]=1000001, [1024:2047]=1, 
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.GatewayToClient=
      Messaging.Received.BatchSizeBytesHistogram.Bytes.PerSocketDirection.SiloToSilo=
      Messaging.Received.Bytes.Header.Current=158000300
      Messaging.Received.Bytes.Total.Current=216001924
      Messaging.Received.Direction.OneWay.Current=0
      Messaging.Received.Direction.Request.Current=0
      Messaging.Received.Direction.Response.Current=1000002
      Messaging.Received.Messages.From.S127.0.0.1:30000:0.Current=1000002
      Messaging.Received.Messages.Total.Current=1000002
      Messaging.Received.MessageSizeHistogram.Bytes=[128:255]=1000001, [1024:2047]=1, 
      Messaging.Rerouted.OneWay.Current=0
      Messaging.Rerouted.Request.Current=0
      Messaging.Rerouted.Response.Current=0
      Messaging.Sent.BatchSize.PerSocketDirection.ClientToGateway=1.000
      Messaging.Sent.BatchSize.PerSocketDirection.GatewayToClient=0.000
      Messaging.Sent.BatchSize.PerSocketDirection.SiloToSilo=0.000
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.ClientToGateway=[128:255]=1000002, 
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.GatewayToClient=
      Messaging.Sent.BatchSizeBytesHistogram.Bytes.PerSocketDirection.SiloToSilo=
      Messaging.Sent.Bytes.Header.Current=130000300
      Messaging.Sent.Bytes.Total.Current=175000357
      Messaging.Sent.Direction.OneWay.Current=0
      Messaging.Sent.Direction.Request.Current=1000002
      Messaging.Sent.Direction.Response.Current=0
      Messaging.Sent.LocalMessages.Current=0
      Messaging.Sent.Messages.To.S127.0.0.1:30000:0.Current=1000002
      Messaging.Sent.Messages.Total.Current=1000002
      Messaging.Sent.MessageSizeHistogram.Bytes=[128:255]=1000002, 
      Networking.Sockets.ClientToGateway.Closed.Current=1
      Networking.Sockets.ClientToGateway.Opened.Current=1
      Networking.Sockets.GatewayToClient.Closed.Current=0
      Networking.Sockets.GatewayToClient.Opened.Current=0
      Networking.Sockets.Silo.Closed.Current=0
      Networking.Sockets.Silo.Opened.Current=0
      Serialization.BufferPool.AllocatedBuffers.Current=250
      Serialization.BufferPool.BuffersInPool=250
      Serialization.BufferPool.CheckedInBuffers.Current=250
      Serialization.BufferPool.CheckedOutBuffers.Current=250
      Serialization.BufferPool.DroppedBuffers.Current=0
      Serialization.BufferPool.DroppedTooLargeBuffers.Current=0
      Serialization.BufferPool.InUse.AllocatedAndNotInPool_Buffers=0
      Serialization.BufferPool.InUse.CheckedOutAndNotCheckedIn_Buffers=0
```