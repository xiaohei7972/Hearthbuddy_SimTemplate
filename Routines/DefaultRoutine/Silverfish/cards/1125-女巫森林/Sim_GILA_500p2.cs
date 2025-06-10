namespace HREngine.Bots
{
	class Sim_GILA_500p2 : SimTemplate //* 翻捡 Scavenge
//[x]<b>Hero Power</b><b>Discover</b> a class spellthat has been playedthis game.
//<b>英雄技能</b><b>发现</b>一张在本局对战中使用过的职业法术牌。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
            };
        }
	}
}