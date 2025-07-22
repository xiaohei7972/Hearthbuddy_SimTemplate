namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_67p2 : SimTemplate //* 火焰诅咒 Curse of Flame
//[x]<b>Hero Power</b>Choose an enemy minion. If itlives until your next turn, deal5 damage to all characters.
//<b>英雄技能</b>选择一个敌方随从。在你的下个回合开始时，如果该随从依然存活，则对所有角色造成5点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}