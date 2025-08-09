namespace HREngine.Bots
{
	//* 英勇狂热者 Brazen Zealot
	//Whenever you summon a minion, gain +1 Attack.
	//每当你召唤一个随从，获得+1攻击力。
	class Sim_ULD_145 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own)
			{
				p.minionGetBuffed(triggerEffectMinion, 1, 0);
			}
		}


	}
}