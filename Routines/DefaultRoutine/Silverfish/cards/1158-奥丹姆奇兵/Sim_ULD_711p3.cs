namespace HREngine.Bots
{
    //* 安拉斐特之核 Anraphet's Core
    //[x]<b>Hero Power</b>Summon a 4/3 Golem.After your hero attacks,refresh this.
    //<b>英雄技能</b>召唤一个4/3的魔像。在你的英雄攻击后，复原此技能。 
    class Sim_ULD_711p3 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_711t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay);
        }
        
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
    }
}