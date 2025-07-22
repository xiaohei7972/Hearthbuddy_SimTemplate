namespace HREngine.Bots
{
	class Sim_TRLA_129s : SimTemplate //* 霜火箭 Frostfire
//Deal $1 damage.
//造成$1点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}