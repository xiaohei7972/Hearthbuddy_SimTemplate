using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_544 : SimTemplate //* 照明弹 Flare
	{
		//All minions lose <b>Stealth</b>. Destroy all enemy <b>Secrets</b>. Draw a card.
		//所有随从失去<b>潜行</b>，摧毁所有敌方<b>奥秘</b>，抽一张牌。
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                m.stealth = false;
            }
            foreach (Minion m in p.enemyMinions)
            {
                m.stealth = false;
            }
            if (ownplay)
            {
                p.enemySecretCount = 0;
                p.enemySecretList.Clear();
            }
            else
            {
                p.ownSecretsIDList.Clear();
            }
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

    }

}