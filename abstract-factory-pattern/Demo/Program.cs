using Sample;

new Client(new ConcreateFactoryA()).DoInteraction();
new Client(new ConcreateFactoryB()).DoInteraction();

new Client(new ConcreateFactoryA()).DoReverseInteraction();
new Client(new ConcreateFactoryB()).DoReverseInteraction();


Order sale = new Order(new GuitarSale());
sale.CompleteOrder("Ibanez");

Order rent = new Order(new KeyboardRental());
rent.CompleteOrder("Roland");