using AdapterExample;

Driver driver = new Driver();
driver.Travel(new Auto());
driver.Travel(new TransportToAnimalAdapter(new Camel()));
driver.Travel(new TransportToSwimmableAdapter(new Submarine()));