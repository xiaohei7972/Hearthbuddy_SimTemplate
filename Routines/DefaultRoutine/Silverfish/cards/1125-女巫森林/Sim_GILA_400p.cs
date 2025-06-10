namespace HREngine.Bots
{
	class Sim_GILA_400p : SimTemplate //* 狗哨 Dog Whistle
//<b>Hero Power</b>Summon a 1/1 Bloodhound with <b>Rush</b>.
//<b>英雄技能</b>召唤一只1/1并具有<b>突袭</b>的血猎犬。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}