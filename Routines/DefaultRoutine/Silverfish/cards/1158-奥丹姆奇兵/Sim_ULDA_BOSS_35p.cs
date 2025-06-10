namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_35p : SimTemplate //* 复仇构造体 Vengeful Construct
//[x]<b>Hero Power</b>Choose a minion with 2 orless Health. Destroyit and its neighbors.
//<b>英雄技能</b>选择一个生命值小于或等于2点的随从。消灭该随从及相邻的随从。 
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