namespace HREngine.Bots
{
	class Sim_ULDA_705d : SimTemplate //* 爆破大师占位 Boommaster Dummy
//Dummy Hook Up ULDA_705e
//虚拟关联ULDA705e 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}