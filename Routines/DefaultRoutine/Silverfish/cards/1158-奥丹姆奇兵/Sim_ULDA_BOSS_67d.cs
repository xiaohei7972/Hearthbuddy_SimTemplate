namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_67d : SimTemplate //* 塔卡恒洗牌占位 Tekhan Shuffle Dummy
//
// 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}