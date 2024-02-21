

using practicee_1;

Address address = new Address();
address.RoadNo = "205";
address.HouseNo = "h-1290";
address.PostCode = "5204";
address.Area = "Rajia sultana";
address.District = "Dinajpur";



Person person1 = new Person();
person1.PresentAddress = address;

Address MyAddress = person1.PresentAddress;
string houseno=person1.PresentAddress.HouseNo;
string roadno=person1.PresentAddress.RoadNo;



Console.ReadKey();