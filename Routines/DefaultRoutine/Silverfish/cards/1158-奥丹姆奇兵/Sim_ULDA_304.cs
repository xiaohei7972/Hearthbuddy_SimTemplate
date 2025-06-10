namespace HREngine.Bots
{
	class Sim_ULDA_304 : SimTemplate //* 重生法杖 Staff of Renewal
//Resurrect 7 friendly minions withthe highest Cost.Give them <b>Taunt</b>.
//复活七个法力值消耗最高的友方随从，并使其获得<b>嘲讽</b>。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME),
            };
        }
	}
}