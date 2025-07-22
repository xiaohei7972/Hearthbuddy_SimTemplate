namespace HREngine.Bots
{
	class Sim_ULDA_724d : SimTemplate //* 法术护盾占位 Spellshields Dummy
//Dummy Hook Up ULDA_035e
//虚拟关联ULDA035e 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}