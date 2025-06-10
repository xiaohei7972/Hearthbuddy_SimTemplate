namespace HREngine.Bots
{
	class Sim_DALA_721 : SimTemplate //* 变形复制仪 Duplatransmogrifier
//Choose a friendly minion. Replace all minions in your Adventure deck with copies of it.
//选择一个友方随从。将你的冒险模式套牌中的所有随从牌替换为该随从的复制。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}