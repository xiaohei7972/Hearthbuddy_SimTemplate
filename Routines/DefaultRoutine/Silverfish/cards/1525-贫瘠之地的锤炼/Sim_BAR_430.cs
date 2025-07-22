using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_430 : SimTemplate //* 部落特工 Horde Operative
	{
        //<b>Battlecry:</b> Copy your opponent's <b>Secrets</b> and put them into play.
        //<b>战吼：</b>复制你对手的<b>奥秘</b>并置入战场。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                for (var i = 0; i < p.enemySecretList.Count; i++)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.None);
                }
            } else
            {
                for (var i = 0; i < p.ownSecretsIDList.Count; i++)
                {
                    p.enemySecretList.Add(new SecretItem());
                }
            }
        }

    }
}
