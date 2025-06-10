namespace HREngine.Bots
{
	class Sim_LOOTA_817 : SimTemplate //* 始生之杖 Primordial Wand
//[x]<b>Adapt</b> a friendly minion.Repeat for each bossyou've defeated this run.@<b>Adapt</b> a friendly minion {0} |4(time, times).
//<b>进化</b>一个友方随从。在本次冒险中每打败过一个首领，就重复一次。@使一个友方随从<b>进化</b>{0}次。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}