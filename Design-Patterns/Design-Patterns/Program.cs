// See https://aka.ms/new-console-template for more information

using Design_Patterns.Builder;
using Design_Patterns.Builder.Builder_Facade;

var fluentBuilder = Person.New;
fluentBuilder.WorksAt("XYZ").LivesOn("Street 4").WorksAsA("Software Engineer");

var facadeBuilder = new PersonBuilder();
facadeBuilder.Works.At("XYZ")
             .Lives.In("Karachi")
             .Works.AsA("Software Engineer")
             .Lives.On("Street 4");

