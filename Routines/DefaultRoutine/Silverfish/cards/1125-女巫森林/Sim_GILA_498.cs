namespace HREngine.Bots
{
	class Sim_GILA_498 : SimTemplate //* 皮糙肉厚 Thick Hide
//Add to your deck:'{0}''{1}''{2}'
//加入你的牌库：“{0}”“{1}”“{2}” 
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