# Technical Questions

**Resilience side-effects**

1. Is not possible if the Order Service respond a 201 status code. To allow that it should return a specific code (413, 503, etc.)

**From the message producer standpoint**

1. Is not possible to guarantee the order on the messages in a distributed system. However, you can use different techincs as Consistent Hashing Exchange to guarantee the order.

2. Yes, it's possible. To avoid that you can use RabbitMQ deduplication, this tecnique adds a header with a unique identifier.


**Message semantics**

In the case we use ShipOrderCommand instead of OrderConfirmedEvent, the main difference is the handling of the message. In the command case, we'll not use a queue to send the message to the different consumers and we'll need to implement the different parts to guarantee that the message is arriving to the multiple externals services. In this case, we are dealing with the implementation overhead each time a new external consumer adds to the solution.
