namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_67t : SimTemplate //* 终极灾祸？！ The Final Plague?!
//<i>Resummon that which was long dead.</i>
//<i>再次唤起沉落已久的灾祸。</i> 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}