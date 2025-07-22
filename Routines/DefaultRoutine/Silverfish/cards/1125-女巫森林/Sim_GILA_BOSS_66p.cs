namespace HREngine.Bots
{
	class Sim_GILA_BOSS_66p : SimTemplate //* …… . . .
//<b>Hero Power</b><b>Silence</b> a minion.
//<b>英雄技能</b><b>沉默</b>一个随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}