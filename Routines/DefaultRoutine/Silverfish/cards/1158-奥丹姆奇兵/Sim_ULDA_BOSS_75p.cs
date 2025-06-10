namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_75p : SimTemplate //* 捕猎弱者 Hunt the Weak
//[x]<b>Hero Power</b>Deal $@ damage to a minion andgain 1 bonus damage. If it dies,lose all bonus damage.
//<b>英雄技能</b>对一个随从造成$@点伤害并获得1点额外伤害。如果该随从死亡，则失去所有额外伤害。 
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