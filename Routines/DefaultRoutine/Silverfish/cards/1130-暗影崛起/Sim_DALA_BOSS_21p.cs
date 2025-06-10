namespace HREngine.Bots
{
	class Sim_DALA_BOSS_21p : SimTemplate //* 预言 Prediction
//<b>Hero Power</b>Put a random class <b>Secret</b> into the battlefield.
//<b>英雄技能</b>将一个随机职业的<b>奥秘</b>置入战场。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_OR_ENEMY_HERO),
            };
        }
	}
}