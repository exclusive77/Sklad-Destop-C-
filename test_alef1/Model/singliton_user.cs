using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{

    class singliton_user
    {
        List<Users> users = new List<Users>();
        private static singliton_user instance;

        private singliton_user()
        {

        }

        public static singliton_user GetInstance()
        {
            if (instance is null)
            {
                instance = new singliton_user();
            }
            return instance;
        }


        MyDbContext db = new MyDbContext();
        
           
        public void Create(Users item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {

                db.Entry(user).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Users Get(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<Users> GetAll()
        {
            return db.Users.ToList();
        }

        public IEnumerable<Users> GetAll(Func<Users, bool> predicate)
        {
            return db.Users.Where(predicate).ToList();
        }

        public void Update(Users item)
        {
            var user = db.Users.Include(u => u.Emps).FirstOrDefault(u => u.Id == item.Id);
            if (user != null)
            {
                user.UserName = item.UserName;
                user.Password = item.Password;
                user.EmpsId = item.EmpsId;
                //  user.Account = item.Account;
                user.Emps.EmpName = item.Emps.EmpName;
                user.Emps.TaxCode = item.Emps.TaxCode;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
    }


 













