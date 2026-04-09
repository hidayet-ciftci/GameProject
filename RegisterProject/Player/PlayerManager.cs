using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject.Player
{
    public class PlayerManager : IRegisterSystem<Players>
    {
        public List<Players> Players { get; private set; }
        public PlayerManager()
        {
            Players = new List<Players>();
        }
        public void Add(Players player)
        {
            Players.Add(player);
        }
        public void Delete(Players players)
        {
            var entity=Players.Where(p => p.Id.Equals(players.Id)).SingleOrDefault();
            Players.Remove(entity);
        }
        public void Update(Players players)
        {
            var entity = Players.Where(p => p.Id.Equals(players.Id)).SingleOrDefault();
            entity.Ad = players.Ad;
            entity.Soyad = players.Soyad;
            entity.TcNo = players.TcNo;
            entity.BirthDate = players.BirthDate;
        }
        public void Validation(Players players)
        {
            var entity = Players.Where(p => p.Id.Equals(players.Id)).SingleOrDefault();
            if (entity.Ad != players.Ad) Console.WriteLine(" isim yanlis");
            if (entity.Soyad != players.Soyad) Console.WriteLine(" Soy isim yanlis");
            if (entity.TcNo != players.TcNo) Console.WriteLine(" Tc No yanlis");
            if (entity.BirthDate != players.BirthDate) Console.WriteLine("dogum tarihi yanlis");
        }

    }
}
