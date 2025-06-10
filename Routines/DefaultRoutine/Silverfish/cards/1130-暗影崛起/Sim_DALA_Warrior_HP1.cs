namespace HREngine.Bots
{
	class Sim_DALA_Warrior_HP1 : SimTemplate //* 提神酒 Invigorating Brew
//[x]<b>Hero Power</b>Deal $1 damage toa minion and giveit +2_Attack.
//<b>英雄技能</b>对一个随从造成$1点伤害，并使其获得+2攻击力。 
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