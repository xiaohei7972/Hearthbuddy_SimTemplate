namespace HREngine.Bots
{
	class Sim_DALA_Warrior_HP2 : SimTemplate //* 暗中爆破 Undermine
//[x]<b>Hero Power</b>Shuffle two Explosivesinto your opponent'sdeck.
//<b>英雄技能</b>将两张“炸药” 牌洗入你对手的牌库。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}