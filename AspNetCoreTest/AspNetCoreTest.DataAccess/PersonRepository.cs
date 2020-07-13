using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTest.DataAccess
{
    public class PersonRepository
    {
        public async Task Add(Person person)
        {
            using (var db = new PersonContext())
            {
                db.Add(person);
                await db.SaveChangesAsync();
            }
        }
    }
}
