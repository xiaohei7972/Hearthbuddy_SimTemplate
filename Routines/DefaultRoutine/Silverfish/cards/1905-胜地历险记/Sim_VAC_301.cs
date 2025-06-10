using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：6 攻击力：4 生命值：4
	//Razzle-Dazzler
	//炫目演出者
	//[x]<b>Battlecry:</b> Summon arandom 5-Cost minion.___Repeat for each spell school____you've cast this game.@ <i>(@)</i>
	//<b>战吼：</b>随机召唤一个法力值消耗为（5）的随从。在本局对战中你每施放过一个派系的法术，重复一次。@<i>（召唤@个）</i>
	class Sim_VAC_301 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取释放的法术派系的数量
            int count = p.CountSpellSchoolsPlayed();

            // 根据数量执行代码
            for (int i = 0; i < count; i++)
            {
                //随机召唤一个法力值消耗为（5）的随从
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getRandomCardForManaMinion(5), pos, ownplay);
            }
        }
    }
}
