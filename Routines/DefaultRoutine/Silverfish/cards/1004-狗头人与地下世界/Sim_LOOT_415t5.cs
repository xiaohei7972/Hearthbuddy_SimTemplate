namespace HREngine.Bots
{
	class Sim_LOOT_415t5 : SimTemplate //* 终极封印 The Final Seal
//[x]Summon a 6/6 Demon.Add 'Azari, the Devourer'to your hand.
//召唤一个6/6的恶魔。将“吞噬者阿扎里”置入你的手牌。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}