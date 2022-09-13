using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.ModelSampleForResponseSwagger
{
    public class PersonExamples : IMultipleExamplesProvider<Person>
    {
        public IEnumerable<SwaggerExample<Person>> GetExamples()
        {
            yield return SwaggerExample.Create("WithContact",
                new Person
                {
                    Name = "Alice",
                    Contact = "alkda@mgmggm.com"

                });

            yield return SwaggerExample.Create("WithoutContact",
               new Person
               {
                   Name = "asuuasu",
                   Contact = "alkda@mgmggm.com"

               });
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
