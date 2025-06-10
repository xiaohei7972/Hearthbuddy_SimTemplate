namespace HREngine.Bots
{
	class Sim_LOOTA_Mage_25 : SimTemplate //* 火焰冲击 Heroic Power
//
// 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}