namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_71px : SimTemplate //* 生命尊主 Lord of Life
//[x]<b>Hero Power</b>Restore a minion'sHealth to full.
//<b>英雄技能</b>为一个随从恢复所有生命值。 
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