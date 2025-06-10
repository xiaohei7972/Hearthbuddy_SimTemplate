namespace HREngine.Bots
{
	class Sim_DALA_BOSS_58p : SimTemplate //* 爆破炸药 Blast Powder
//[x]<b>Hero Power</b>Coat a minion in BlastPowder. When it takesdamage, destroy it.
//<b>英雄技能</b>为一个随从绑上爆破炸药。当它受到伤害时，消灭该随从。 
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