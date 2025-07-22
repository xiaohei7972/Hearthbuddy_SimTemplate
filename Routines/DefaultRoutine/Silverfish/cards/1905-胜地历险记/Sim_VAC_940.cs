using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：2 攻击力：2 生命值：1
	//Party Fiend
	//派对邪犬
	//<b>Battlecry:</b> Summon two 1/1 Felbeasts. Deal 3 damage to your hero.
	//<b>战吼：</b>召唤两只1/1的邪能兽。对你的英雄造成3点伤害。
	class Sim_VAC_940 : SimTemplate
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_940t);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 召唤两只1/1的邪能兽
            p.callKid(kid, own.zonepos - 1, own.own);
            p.callKid(kid, own.zonepos, own.own);

            // 对你的英雄造成3点伤害
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 3);
        }

    }
}
