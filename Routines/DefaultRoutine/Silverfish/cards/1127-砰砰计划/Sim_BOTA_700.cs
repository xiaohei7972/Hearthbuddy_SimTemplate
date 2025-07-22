namespace HREngine.Bots
{
	class Sim_BOTA_700 : SimTemplate //* 镜像 Mirror
//Match the boss'sside of thebattlefield exactly.
//摆出和敌方首领完全相同的战场阵容。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}