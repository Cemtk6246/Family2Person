using NMF.Models;
using NMF.Models.Changes;
using NMF.Models.Repository;
using NMF.Synchronizations;
using NMF.Transformations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family2Person.Families;
using Family2Person.Persons;

namespace Family2Person {
class Program
    {
        private FamilyRegister familyRegister;
        private PersonRegister personRegister;

        private ModelRepository repository = new ModelRepository();

        private Families2PersonsSynchronization synchronization = new Families2PersonsSynchronization();

        public Program()
        {
            var familyRootModel = new Model();
            var personRootModel = new Model();

            familyRegister = new FamilyRegister();
            personRegister = new PersonRegister();

            synchronization.Synchronize(
                synchronization.SynchronizationRule<Families2PersonsSynchronization.FamilyRegisterToPersonRegister>(),
                ref familyRegister, // Familyregister is the left model
                ref personRegister, // Personregister is the right model
                SynchronizationDirection.LeftWins, // prioritizes the left synchronization of left model (without shouldCorrespond it has no impact)
                ChangePropagationMode.TwoWay); // TwoWay means Bidirectional synchronization 

            familyRootModel.RootElements.Add(familyRegister);
            personRootModel.RootElements.Add(personRegister);

            repository.Models.Add(new Uri("ttc:source"), familyRootModel);
            repository.Models.Add(new Uri("ttc:target"), personRootModel);
        }

        static void Main(string[] args)
        {
            // 1. synchronization from family to person.
            var program = new Program();
            program.familyRegister.Families.Add(new Family {
                Father = new FamilyMember {
                    Name = "Marx"
                }, 
                Name = "Mustermann"
            });

            var fatherFirstName = program.familyRegister.Families.First().Father;
            var familyName = program.familyRegister.Families.First().Name;
            
            var person = program.personRegister.Persons.First().Name;

            Console.WriteLine(fatherFirstName);
            Console.WriteLine(familyName);
            Console.WriteLine(person);

            // 2. synchronization from person to family.
            program.personRegister.Persons.Add(new Male{
                Name = "Smith, John"
            });

            var smith = program.familyRegister.Families.Reverse().First().Name;
            var john = program.familyRegister.Families.Reverse().First().Father;
            Console.WriteLine(smith);
            Console.WriteLine(john);
        }
    }
}