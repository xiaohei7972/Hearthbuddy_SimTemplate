namespace HREngine.Bots
{
	class Sim_ULDA_900 : SimTemplate //* 伊莉斯的随机套牌 Elise Random Deck
//Start the run with a deck of random cards.
//用一副随机套牌开始冒险。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}