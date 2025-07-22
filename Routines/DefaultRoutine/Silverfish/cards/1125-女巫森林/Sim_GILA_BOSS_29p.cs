namespace HREngine.Bots
{
	class Sim_GILA_BOSS_29p : SimTemplate //* 痴迷 Infatuation
//<b>Hero Power</b>Gain control of enemy minions with 1 or less Attack.
//<b>英雄技能</b>获得所有攻击力小于或等于1的敌方随从的控制权。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}