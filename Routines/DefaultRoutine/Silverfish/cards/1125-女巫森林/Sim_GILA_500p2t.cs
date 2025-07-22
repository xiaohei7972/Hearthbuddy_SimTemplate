namespace HREngine.Bots
{
	class Sim_GILA_500p2t : SimTemplate //* 小石头 A Small Rock
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