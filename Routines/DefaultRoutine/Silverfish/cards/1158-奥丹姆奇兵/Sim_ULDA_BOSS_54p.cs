namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_54p : SimTemplate //* 军团驾到 Cavalry of E.V.I.L.
//[x]<b>Hero Power</b>Deal 1 damage to aminion and give it <b>Charge</b>.
//<b>英雄技能</b>对一个随从造成1点伤害，并使其获得<b>冲锋</b>。 
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