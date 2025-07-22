namespace HREngine.Bots
{
	class Sim_DALA_726 : SimTemplate //* 大师级阴谋 Master Scheme
//[x]Deal $@ damage. Draw@ |4(card, cards). Gain @ Armor.Summon @ <b>Boom |4(Bot, Bots)</b>.<i>(Upgrades each turn!)</i>
//造成$@点伤害。抽@张牌。获得@点护甲。召唤@个<b>砰砰机器人</b>。<i>（每回合都会升级！）</i> 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}