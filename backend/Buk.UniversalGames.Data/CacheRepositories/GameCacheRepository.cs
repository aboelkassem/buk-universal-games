﻿using Buk.UniversalGames.Data.Interfaces;
using Buk.UniversalGames.Data.Models;
using Buk.UniversalGames.Data.Models.Internal;
using Buk.UniversalGames.Data.Repositories;
using Microsoft.Extensions.Logging;

namespace Buk.UniversalGames.Data.CacheRepositories
{
    public class GameCacheRepository : IGameRepository
    {
        private readonly ILogger<GameCacheRepository> _logger;
        private readonly GameDataRepository _data;

        public GameCacheRepository(ILogger<GameCacheRepository> logger, DataContext dataContext)
        {
            _logger = logger;
            _data = new GameDataRepository(dataContext);
        }

        public List<Game> GetGames()
        {
            return _data.GetGames();
        }

        public List<MatchListItem> GetMatches(Team team)
        {
            return _data.GetMatches(team);
        }

        public List<MatchListItem> GetGameMatches(int leagueId, int gameId)
        {
            return _data.GetGameMatches(leagueId, gameId);
        }
    }
}
