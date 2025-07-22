using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_WON_142 : SimTemplate //* 展馆茶壶 Menagerie Jug
    {
        //[x]<b>Battlecry:</b> Give 3 randomfriendly minions of differentminion types +3/+3.
        // <b>战吼：</b>随机使三个不同类型的友方随从获得+3/+3。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? new List<Minion>(p.ownMinions) : new List<Minion>(p.enemyMinions);

            if (temp.Count == 0) return; // 没有友方随从，则不执行 Buff

            int count = Math.Min(3, temp.Count); // 确保最多 Buff 3 个随从
            
            for (int i = 0; i < count; i++)
            {
                Minion selected = temp[0]; // 先选择列表中的第一个随从
                temp.RemoveAt(0); // 选中后立即移除，防止重复选择

                p.minionGetBuffed(selected, 3, 3); // 给予 Buff
            }
        }
    }
}


