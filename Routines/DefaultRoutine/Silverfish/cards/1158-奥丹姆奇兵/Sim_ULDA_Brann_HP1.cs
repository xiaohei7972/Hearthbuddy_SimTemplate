namespace HREngine.Bots
{
	class Sim_ULDA_Brann_HP1 : SimTemplate //* 散射 Spread Shot
//[x]<b>Hero Power</b>Deal $1 damage,then deal $1 damage tothe enemy hero.
//<b>英雄技能</b>造成$1点伤害，再对敌方英雄造成$1点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}