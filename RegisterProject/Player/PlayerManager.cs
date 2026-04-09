using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject.Player
{
    public class PlayerManager : IPlayerService
    {
        IPlayerValidationService _playerValidationService;
        public List<Players> Players { get; private set; }
        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            Players = new List<Players>();
            _playerValidationService = playerValidationService;
            
        }
        public void Add(Players player)
        {
            if (_playerValidationService.validate(player))
            {
                Players.Add(player);
            }
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
        

    }
}
