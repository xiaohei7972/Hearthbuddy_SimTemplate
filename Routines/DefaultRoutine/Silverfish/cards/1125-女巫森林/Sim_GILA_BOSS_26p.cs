namespace HREngine.Bots
{
	class Sim_GILA_BOSS_26p : SimTemplate //* 捉捕 Nab
//<b>Hero Power</b>Put an enemy minion into a sack.
//<b>英雄技能</b>将一个敌方随从装进袋子里。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}