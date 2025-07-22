namespace HREngine.Bots
{
	class Sim_LOOT_415t3 : SimTemplate //* 第三封印 The Third Seal
//Summon a 4/4 Demon. Add 'The Fourth Seal' to your hand.
//召唤一个4/4的恶魔。将“第四封印”置入你的手牌。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}