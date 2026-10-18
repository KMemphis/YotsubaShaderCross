#region MS-PL License - Copyright (c) 2026 Memphis Yomael Núñez Cruz - Dominican Republic
/*
╔════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                    ║
║  ███╗   ███╗███████╗      ██████╗ ██╗                                              ║
║  ████╗ ████║██╔════╝      ██╔══██╗██║                                              ║
║  ██╔████╔██║███████╗█████╗██████╔╝██║                                              ║
║  ██║╚██╔╝██║╚════██║╚════╝██╔═══╝ ██║                                              ║
║  ██║ ╚═╝ ██║███████║      ██║     ███████╗                                         ║
║  ╚═╝     ╚═╝╚══════╝      ╚═╝     ╚══════╝                                         ║
║                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════╣
║  Copyright (c) 2026 Memphis Yomael Núñez Cruz - Dominican Republic                 ║
╠════════════════════════════════════════════════════════════════════════════════════╣
║                                                                                    ║
║  Microsoft Public License (MS-PL)                                                  ║
║                                                                                    ║
║  This license governs use of the accompanying software. If you use the software,   ║
║  you accept this license. If you do not accept the license, do not use the         ║
║  software.                                                                         ║
║                                                                                    ║
║  1. Definitions                                                                    ║
║  The terms "reproduce," "reproduction," "derivative works," and "distribution"     ║
║  have the same meaning here as under U.S. copyright law.                           ║
║  A "contribution" is the original software, to which copyright notices are         ║
║  attached, and any additions or changes to the software.                           ║
║  A "contributor" is any person that distributes its contribution under this        ║
║  license.                                                                          ║
║  "Licensed patents" are a contributor's patent claims that read directly on its    ║
║  contribution.                                                                     ║
║                                                                                    ║
║  2. Grant of Rights                                                                ║
║  (A) Copyright Grant- Subject to the terms of this license, including the license  ║
║  conditions and limitations in section 3, each contributor grants you a non-       ║
║  exclusive, worldwide, royalty-free copyright license to reproduce its             ║
║  contribution, prepare derivative works of its contribution, and distribute its    ║
║  contribution or any derivative works that you create.                             ║
║  (B) Patent Grant- Subject to the terms of this license, including the license     ║
║  conditions and limitations in section 3, each contributor grants you a non-       ║
║  exclusive, worldwide, royalty-free license under its licensed patents to make,    ║
║  have made, use, sell, offer for sale, import, and/or otherwise dispose of its     ║
║  contribution in the software or derivative works of the contribution in the       ║
║  software.                                                                         ║
║                                                                                    ║
║  3. Conditions and Limitations                                                     ║
║  (A) No Trademark License- This license does not grant you rights to use any       ║
║  contributors' name, logo, or trademarks.                                          ║
║  (B) If you bring a patent claim against any contributor over patents that you     ║
║  claim are infringed by the software, your patent license from such contributor    ║
║  to the software ends automatically.                                               ║
║  (C) If you distribute any portion of the software, you must retain all copyright, ║
║  patent, trademark, and attribution notices that are present in the software.      ║
║  (D) If you distribute any portion of the software in source code form, you may do ║
║  so only under this license by including a complete copy of this license with      ║
║  your distribution. If you distribute any portion of the software in compiled or   ║
║  object code form, you may only do so under a license that complies with this      ║
║  license.                                                                          ║
║  (E) The software is licensed "as-is." You bear the risk of using it. The          ║
║  contributors give no express warranties, guarantees or conditions. You may have   ║
║  additional consumer rights under your local laws which this license cannot        ║
║  change. To the extent permitted under your local laws, the contributors exclude   ║
║  the implied warranties of merchantability, fitness for a particular purpose and   ║
║  non-infringement.                                                                 ║
║                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════╝
*/
#endregion

// Automatically translated from SPIRV-Cross (https://github.com/KhronosGroup/SPIRV-Cross), commit 300681b.
// Upstream sources: spirv_cfg.cpp, spirv_cfg.hpp
// Upstream copyright: Copyright 2016-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class CFG
{
    public CFG(Compiler compiler_, SPIRFunction func_)
    {
        this.compiler = compiler_;
        this.func = func_;
        this.preceding_edges = new UnorderedMap<uint, CppVector<uint>>();
        this.virtual_dominance_preceding_edges = new UnorderedMap<uint, CppVector<uint>>();
        this.succeeding_edges = new UnorderedMap<uint, CppVector<uint>>();
        this.immediate_dominators = new UnorderedMap<uint, uint>();
        this.visit_order = new UnorderedMap<uint, CFG.VisitOrder>();
        this.post_order = new CppVector<uint>();
        this.empty_vector = new CppVector<uint>();
        this.visit_stack = new CppVector<uint>();
        build_post_order_visit_order();
        build_immediate_dominators();
    }
    public Compiler get_compiler()
    {
        return compiler;
    }
    public SPIRFunction get_function()
    {
        return func;
    }
    public uint get_immediate_dominator(uint block)
    {
        var itr = immediate_dominators.find(block);
        if (itr != Std.end(immediate_dominators))
        {
            return itr.deref().second;
        }
        else
        {
            return 0u;
        }
    }
    public bool is_reachable(uint block)
    {
        return visit_order.count(block) != 0UL;
    }
    public uint get_visit_order(uint block)
    {
        var itr = visit_order.find(block);
        int v = itr.deref().second.order;
        return unchecked((uint)v);
    }
    public uint find_common_dominator(uint a, uint b)
    {
        while (a != b)
        {
            if (get_visit_order(a) < get_visit_order(b))
            {
                a = get_immediate_dominator(a);
            }
            else
            {
                b = get_immediate_dominator(b);
            }
        }
        return a;
    }
    public CppVector<uint> get_preceding_edges(uint block)
    {
        var itr = preceding_edges.find(block);
        if (itr != Std.end(preceding_edges))
        {
            return itr.deref().second;
        }
        else
        {
            return empty_vector;
        }
    }
    public CppVector<uint> get_succeeding_edges(uint block)
    {
        var itr = succeeding_edges.find(block);
        if (itr != Std.end(succeeding_edges))
        {
            return itr.deref().second;
        }
        else
        {
            return empty_vector;
        }
    }
    public uint find_loop_dominator(uint block_id)
    {
        while (block_id != 4294967295u)
        {
            var itr = preceding_edges.find(block_id);
            if (itr == Std.end(preceding_edges))
            {
                return 4294967295u;
            }
            if (itr.deref().second.empty())
            {
                return 4294967295u;
            }
            uint pred_block_id = 4294967295u;
            bool ignore_loop_header = false;
            {
                foreach (uint pred in itr.deref().second)
                {
                    var pred_block = compiler.get__SPIRBlock(pred);
                    if (unchecked((int)pred_block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && ((uint)pred_block.merge_block) == ((uint)new TypedID_TypeNone(block_id)))
                    {
                        pred_block_id = pred;
                        ignore_loop_header = true;
                        break;
                    }
                    else
                    if (unchecked((int)pred_block.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection) && ((uint)pred_block.next_block) == ((uint)new TypedID_TypeNone(block_id)))
                    {
                        pred_block_id = pred;
                        break;
                    }
                }
            }
            if (pred_block_id == 4294967295u)
            {
                pred_block_id = itr.deref().second.front();
            }
            block_id = pred_block_id;
            if (!ignore_loop_header && block_id != 0u)
            {
                var block = compiler.get__SPIRBlock(block_id);
                if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop))
                {
                    return block_id;
                }
            }
        }
        return block_id;
    }
    public bool node_terminates_control_flow_in_sub_graph(TypedID_TypeBlock from, TypedID_TypeBlock to)
    {
        var from_block = compiler.get__SPIRBlock(((uint)from));
        TypedID_TypeBlock ignore_block_id = new TypedID_TypeBlock(0u);
        if (unchecked((int)from_block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop))
        {
            ignore_block_id = from_block.merge_block;
        }
        while (((uint)to) != ((uint)from))
        {
            var pred_itr = preceding_edges.find(((uint)to));
            if (pred_itr == Std.end(preceding_edges))
            {
                return false;
            }
            DominatorBuilder builder = new DominatorBuilder(this);
            {
                foreach (uint edge in pred_itr.deref().second)
                {
                    builder.add_block(edge);
                }
            }
            uint dominator = builder.get_dominator();
            if (dominator == 0u)
            {
                return false;
            }
            var dom = compiler.get__SPIRBlock(dominator);
            bool true_path_ignore = false;
            bool false_path_ignore = false;
            bool merges_to_nothing = unchecked((int)dom.merge) == unchecked((int)SPIRBlock.Merge.MergeNone) || unchecked((int)dom.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection) && ((uint)dom.next_block) != 0u && unchecked((int)compiler.get__SPIRBlock(((uint)dom.next_block)).terminator) == unchecked((int)SPIRBlock.Terminator.Unreachable) || unchecked((int)dom.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && ((uint)dom.merge_block) != 0u && unchecked((int)compiler.get__SPIRBlock(((uint)dom.merge_block)).terminator) == unchecked((int)SPIRBlock.Terminator.Unreachable);
            if (((uint)dom.self) == ((uint)from) || merges_to_nothing)
            {
                if (((uint)ignore_block_id) != 0u && unchecked((int)dom.terminator) == unchecked((int)SPIRBlock.Terminator.Select))
                {
                    var true_block = compiler.get__SPIRBlock(((uint)dom.true_block));
                    var false_block = compiler.get__SPIRBlock(((uint)dom.false_block));
                    var ignore_block = compiler.get__SPIRBlock(((uint)ignore_block_id));
                    true_path_ignore = compiler.execution_is_branchless(true_block, ignore_block);
                    false_path_ignore = compiler.execution_is_branchless(false_block, ignore_block);
                }
            }
            if (unchecked((int)dom.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection) && ((uint)dom.next_block) == ((uint)to) || unchecked((int)dom.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && ((uint)dom.merge_block) == ((uint)to) || unchecked((int)dom.terminator) == unchecked((int)SPIRBlock.Terminator.Direct) && ((uint)dom.next_block) == ((uint)to) || unchecked((int)dom.terminator) == unchecked((int)SPIRBlock.Terminator.Select) && ((uint)dom.true_block) == ((uint)to) && false_path_ignore || unchecked((int)dom.terminator) == unchecked((int)SPIRBlock.Terminator.Select) && ((uint)dom.false_block) == ((uint)to) && true_path_ignore)
            {
                to = new TypedID_TypeBlock(dominator);
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    public Compiler compiler;
    public SPIRFunction func;
    public UnorderedMap<uint, CppVector<uint>> preceding_edges = new UnorderedMap<uint, CppVector<uint>>();
    public UnorderedMap<uint, CppVector<uint>> virtual_dominance_preceding_edges = new UnorderedMap<uint, CppVector<uint>>();
    public UnorderedMap<uint, CppVector<uint>> succeeding_edges = new UnorderedMap<uint, CppVector<uint>>();
    public UnorderedMap<uint, uint> immediate_dominators = new UnorderedMap<uint, uint>();
    public UnorderedMap<uint, CFG.VisitOrder> visit_order = new UnorderedMap<uint, CFG.VisitOrder>();
    public CppVector<uint> post_order = new CppVector<uint>();
    public CppVector<uint> empty_vector = new CppVector<uint>();
    public void add_branch(uint from, uint to)
    {
        Globals.add_unique(preceding_edges[to], from);
        Globals.add_unique(succeeding_edges[from], to);
    }
    public void add_virtual_dominance_branch(uint from, uint to)
    {
        Globals.add_unique(virtual_dominance_preceding_edges[to], from);
    }
    public void build_post_order_visit_order()
    {
        uint block = ((uint)func.entry_block);
        visit_count = 0u;
        visit_order.clear();
        post_order.clear();
        post_order_visit_entry(block);
    }
    public void build_immediate_dominators()
    {
        immediate_dominators.clear();
        immediate_dominators[((uint)func.entry_block)] = ((uint)func.entry_block);
        {
            for (ulong i = post_order.size(); i != 0UL; i--)
            {
                uint block = post_order[i - 1UL];
                var resolve_preds = (CppVector<uint> pred) =>
                {
                    if (pred.empty())
                    {
                        return;
                    }
                    {
                        foreach (uint edge in pred)
                        {
                            if (this.immediate_dominators[block] != 0u)
                            {
                                this.immediate_dominators[block] = this.find_common_dominator(this.immediate_dominators[block], edge);
                            }
                            else
                            {
                                this.immediate_dominators[block] = edge;
                            }
                        }
                    }
                };
                resolve_preds(preceding_edges[block]);
                resolve_preds(virtual_dominance_preceding_edges[block]);
            }
        }
    }
    public void post_order_visit_branches(uint block_id)
    {
        var block = compiler.get__SPIRBlock(block_id);
        ref var visit = ref visit_order[block_id];
        if (visit.visited_branches)
        {
            return;
        }
        visit.visited_branches = true;
        if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop))
        {
            visit_branch(((uint)block.merge_block));
        }
        else
        if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection))
        {
            visit_branch(((uint)block.next_block));
        }
        {
            switch (unchecked((int)block.terminator))
            {
                case unchecked((int)SPIRBlock.Terminator.Direct):
                {
                    visit_branch(((uint)block.next_block));
                    break;
                }
                case unchecked((int)SPIRBlock.Terminator.Select):
                {
                    visit_branch(((uint)block.true_block));
                    visit_branch(((uint)block.false_block));
                    break;
                }
                case unchecked((int)SPIRBlock.Terminator.MultiSelect):
                {
                    {
                        var cases = compiler.get_case_list(block);
                        {
                            foreach (SPIRBlock.Case target in cases)
                            {
                                visit_branch(((uint)target.block));
                            }
                        }
                        if (((uint)block.default_block) != 0u)
                        {
                            visit_branch(((uint)block.default_block));
                        }
                        break;
                    }
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public void post_order_visit_resolve(uint block_id)
    {
        var block = compiler.get__SPIRBlock(block_id);
        ref var visit_block = ref visit_order[block_id];
        ref var visited = ref visit_order[block_id].visited_resolve;
        if (visited)
        {
            return;
        }
        if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && !is_back_edge(((uint)block.merge_block)))
        {
            add_branch(block_id, ((uint)block.merge_block));
        }
        if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection) && !is_back_edge(((uint)block.next_block)))
        {
            add_virtual_dominance_branch(block_id, ((uint)block.next_block));
        }
        {
            switch (unchecked((int)block.terminator))
            {
                case unchecked((int)SPIRBlock.Terminator.Direct):
                {
                    if (!is_back_edge(((uint)block.next_block)))
                    {
                        add_branch(block_id, ((uint)block.next_block));
                    }
                    break;
                }
                case unchecked((int)SPIRBlock.Terminator.Select):
                {
                    if (!is_back_edge(((uint)block.true_block)))
                    {
                        add_branch(block_id, ((uint)block.true_block));
                    }
                    if (!is_back_edge(((uint)block.false_block)))
                    {
                        add_branch(block_id, ((uint)block.false_block));
                    }
                    break;
                }
                case unchecked((int)SPIRBlock.Terminator.MultiSelect):
                {
                    {
                        var cases = compiler.get_case_list(block);
                        {
                            foreach (SPIRBlock.Case target in cases)
                            {
                                if (!is_back_edge(((uint)target.block)))
                                {
                                    add_branch(block_id, ((uint)target.block));
                                }
                            }
                        }
                        if (((uint)block.default_block) != 0u && !is_back_edge(((uint)block.default_block)))
                        {
                            add_branch(block_id, ((uint)block.default_block));
                        }
                        break;
                    }
                }
                default:
                {
                    break;
                }
            }
        }
        if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection) && !is_back_edge(((uint)block.next_block)))
        {
            var pred_itr = preceding_edges.find(((uint)block.next_block));
            if (pred_itr != Std.end(preceding_edges))
            {
                var pred = pred_itr.deref().second;
                var succ_itr = succeeding_edges.find(block_id);
                ulong num_succeeding_edges = 0UL;
                if (succ_itr != Std.end(succeeding_edges))
                {
                    num_succeeding_edges = succ_itr.deref().second.size();
                }
                if (unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.MultiSelect) && num_succeeding_edges == 1UL)
                {
                    if (!pred.empty())
                    {
                        add_branch(block_id, ((uint)block.next_block));
                    }
                }
                else
                {
                    if (pred.size() == 1UL && pred.begin().deref() != block_id)
                    {
                        add_branch(block_id, ((uint)block.next_block));
                    }
                }
            }
            else
            {
                add_branch(block_id, ((uint)block.next_block));
            }
        }
        visited = true;
        visit_block.order = unchecked((int)++visit_count);
        post_order.push_back(block_id);
    }
    public void post_order_visit_entry(uint block)
    {
        visit_stack.push_back(block);
        while (!visit_stack.empty())
        {
            bool keep_iterating = default;
            do
            {
                uint to_visit = visit_stack.back();
                last_visited_size = visit_stack.size();
                post_order_visit_branches(to_visit);
                keep_iterating = last_visited_size != visit_stack.size();
                if (keep_iterating)
                {
                    Std.reverse(visit_stack.begin() + unchecked((long)last_visited_size), visit_stack.end());
                }
            }
            while (keep_iterating);
            while (!visit_stack.empty() && visit_order[visit_stack.back()].visited_branches)
            {
                post_order_visit_resolve(visit_stack.back());
                visit_stack.pop_back();
            }
        }
    }
    public uint visit_count = 0u;
    public bool is_back_edge(uint to)
    {
        var itr = visit_order.find(to);
        return itr != Std.end(visit_order) && itr.deref().second.visited_branches && !itr.deref().second.visited_resolve;
    }
    public bool has_visited_branch(uint to)
    {
        var itr = visit_order.find(to);
        return itr != Std.end(visit_order) && itr.deref().second.visited_branches;
    }
    public void visit_branch(uint block_id)
    {
        if (Std.find(visit_stack.begin() + unchecked((long)last_visited_size), visit_stack.end(), block_id) == visit_stack.end() && !has_visited_branch(block_id))
        {
            visit_stack.push_back(block_id);
        }
    }
    public CppVector<uint> visit_stack = new CppVector<uint>();
    public ulong last_visited_size = 0UL;
    public void walk_from__lambda(UnorderedSet<uint> seen_blocks, uint block, Func<uint, bool> op)
    {
        if (seen_blocks.count(block) != 0UL)
        {
            return;
        }
        seen_blocks.insert(block);
        if (op(block))
        {
            {
                foreach (uint b in get_succeeding_edges(block))
                {
                    walk_from__lambda(seen_blocks, b, op);
                }
            }
        }
    }

    protected virtual void FixClone()
    {
        this.preceding_edges = this.preceding_edges.Clone(null, __e => __e.Clone());
        this.virtual_dominance_preceding_edges = this.virtual_dominance_preceding_edges.Clone(null, __e => __e.Clone());
        this.succeeding_edges = this.succeeding_edges.Clone(null, __e => __e.Clone());
        this.immediate_dominators = this.immediate_dominators.Clone();
        this.visit_order = this.visit_order.Clone(null, __e => __e.Clone());
        this.post_order = this.post_order.Clone();
        this.empty_vector = this.empty_vector.Clone();
        this.visit_stack = this.visit_stack.Clone();
    }

    public CFG Clone()
    {
        var __c = (CFG)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(CFG o)
    {
        this.compiler = o.compiler;
        this.func = o.func;
        this.preceding_edges = o.preceding_edges.Clone(null, __e => __e.Clone());
        this.virtual_dominance_preceding_edges = o.virtual_dominance_preceding_edges.Clone(null, __e => __e.Clone());
        this.succeeding_edges = o.succeeding_edges.Clone(null, __e => __e.Clone());
        this.immediate_dominators = o.immediate_dominators.Clone();
        this.visit_order = o.visit_order.Clone(null, __e => __e.Clone());
        this.post_order = o.post_order.Clone();
        this.empty_vector = o.empty_vector.Clone();
        this.visit_count = o.visit_count;
        this.visit_stack = o.visit_stack.Clone();
        this.last_visited_size = o.last_visited_size;
    }

    public partial class VisitOrder
    {
        public int order = -1;
        public bool visited_resolve = false;
        public bool visited_branches = false;

        protected virtual void FixClone()
        {
        }

        public VisitOrder Clone()
        {
            var __c = (VisitOrder)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(VisitOrder o)
        {
            this.order = o.order;
            this.visited_resolve = o.visited_resolve;
            this.visited_branches = o.visited_branches;
        }
    }
}
