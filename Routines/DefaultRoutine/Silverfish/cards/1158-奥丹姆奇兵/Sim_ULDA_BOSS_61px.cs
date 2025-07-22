namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_61px : SimTemplate //* 闪电链 Chain Lightning
//[x]<b>Hero Power</b>Deal $1 damage to a minion.Jumps to an adjacentminion until one dies.
//<b>英雄技能</b>对一个随从造成$1点伤害。弹跳至相邻的随从，直到某个随从死亡。 
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