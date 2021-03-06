﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace lua.reader.Graph
{
    public class Graph : IGraph
    {
        #region Fields

        readonly List<IGraphNode> _addedNodes = new List<IGraphNode>();

        private readonly List<IGraphEdge> _edges = new List<IGraphEdge>();

        //private readonly Factory _factory;
        private readonly INodesFactory _nodesFactory;
        private readonly IEdgesFactory _edgesFactory;

        private readonly List<IGraphNode> _nodes = new List<IGraphNode>();

        readonly List<IGraphNode> _removedNodes = new List<IGraphNode>();

        readonly List<IGraphNode> _updatedNodes = new List<IGraphNode>();

        bool _trackChanges;

        #endregion

        #region Constructors and Destructors

        public Graph(Factory factory) : this(factory, factory)
        {
        }

        public Graph(INodesFactory nodesFactory, IEdgesFactory edgesFactory)
        {
            _nodesFactory = nodesFactory;
            _edgesFactory = edgesFactory;
        }

        #endregion

        #region Properties

        public IEnumerable<IGraphNode> AddedNodes
        {
            get
            {
                return _addedNodes;
            }
        }

        public IEnumerable<IGraphEdge> Edges => _edges;

        public IEnumerable<IGraphNode> Nodes => _nodes;

        public IEnumerable<IGraphNode> RemovedNodes
        {
            get
            {
                return _removedNodes;
            }
        }

        public IEnumerable<IGraphNode> UpdatedNodes
        {
            get
            {
                return _updatedNodes;
            }
        }

        #endregion

        #region Public Methods and Operators

        public IGraphNode<TData> Add<TData>(TData data)
        {
            IGraphNode<TData> node = _nodesFactory.Create<IGraphNode<TData>, TData>(this, data);
            //IGraphNode<T> node = _factory.NodesByDataFuncs.Get<Func<IGraph, T, IGraphNode<T>>>(data.GetType())(this, data);
            _nodes.Add(node);
            return node;
        }

        public TNode Add<TNode, TData>(TData data)
            where TNode : IGraphNode<TData>
        {
            TNode node = _nodesFactory.Create<TNode, TData>(this, data);
            //TNode node = (TNode)_factory.NodesByDataFuncs.Get<Func<IGraph, T, IGraphNode<T>>>(data.GetType())(this, data);
            _nodes.Add(node);
            return node;
        }

        public TNode Add<TNode>()
            where TNode : IGraphNode
        {
            TNode node = _nodesFactory.Create<TNode>(this);
            //T node = _factory.NodesByTypeFuncs.Get<Func<IGraph, T>>(typeof(T))(this);
            _nodes.Add(node);
            return node;
        }

        public async Task<IGraphNode<T>> AddAsync<T>(T data, CancellationToken cancellationToken)
        {
            return await Task.Factory.StartNew(() => Add(data), cancellationToken);
        }

        public async Task<TNode> AddAsync<TNode, T>(T data, CancellationToken cancellationToken) where TNode : IGraphNode<T>
        {
            return await Task.Factory.StartNew(() => Add<TNode, T>(data), cancellationToken);
        }

        public async Task<T> AddAsync<T>(CancellationToken cancellationToken) where T : IGraphNode
        {
            return await Task.Factory.StartNew(Add<T>, cancellationToken);
        }

        public IEnumerable<IGraphEdge> EdgesFrom(IGraphNode node)
        {
            return _edges.Where(x => x.From == node);
        }

        public IEnumerable<T> EdgesFrom<T>(IGraphNode node)
            where T : IGraphEdge
        {
            return _edges.Where(x => x.From == node).OfType<T>();
        }

        public async Task<IEnumerable<IGraphEdge>> EdgesFromAsync(IGraphNode node, CancellationToken cancellationToken)
        {
            return await Task.Factory.StartNew(() => EdgesFrom(node), cancellationToken);
        }

        public async Task<IEnumerable<T>> EdgesFromAsync<T>(IGraphNode node, CancellationToken cancellationToken) where T : IGraphEdge
        {
            return await Task.Factory.StartNew(() => EdgesFrom<T>(node), cancellationToken);
        }

        public IEnumerable<IGraphEdge> EdgesTo(IGraphNode node)
        {
            return _edges.Where(x => x.To == node);
        }

        public IEnumerable<T> EdgesTo<T>(IGraphNode node)
            where T : IGraphEdge
        {
            return _edges.Where(x => x.To == node).OfType<T>();
        }

        public async Task<IEnumerable<IGraphEdge>> EdgesToAsync(IGraphNode node, CancellationToken cancellationToken)
        {
            return await Task.Factory.StartNew(() => EdgesTo(node), cancellationToken);
        }

        public async Task<IEnumerable<T>> EdgesToAsync<T>(IGraphNode node, CancellationToken cancellationToken) where T : IGraphEdge
        {
            return await Task.Factory.StartNew(() => EdgesTo<T>(node), cancellationToken);
        }

        public T FindNode<T>(Func<T, bool> predicate)
        {
            return _nodes.OfType<T>().FirstOrDefault(predicate);
        }

        public async Task<T> FindNodeAsync<T>(Func<T, bool> predicate, CancellationToken cancellationToken)
        {
            return await Task.Factory.StartNew(() => FindNode(predicate), cancellationToken);
        }

        public IGraphEdge<TData> Link<TData>(TData data, IGraphNode from, IGraphNode to)
        {
            IGraphEdge<TData> edge = _edgesFactory.Create<IGraphEdge<TData>, TData>(this, from, to, data);
            //IGraphEdge<TData> edge = _factory.EdgesByDataFuncs.Get<Func<IGraph, IGraphNode, IGraphNode, TData, IGraphEdge<TData>>>(data.GetType())(this, from, to, data);
            _edges.Add(edge);
            return edge;
        }

        public TEdge Link<TEdge>(IGraphNode from, IGraphNode to)
            where TEdge : IGraphEdge
        {
            IGraphEdge edge = _edgesFactory.Create<TEdge>(this, from, to);
            //IGraphEdge edge = _factory.EdgesByTypeFuncs.Get<Func<IGraph, IGraphNode, IGraphNode, IGraphEdge>>(typeof(TEdge))(this, from, to);
            _edges.Add(edge);
            return (TEdge)edge;
        }

        public async Task<IGraphEdge<T>> LinkAsync<T>(T data, IGraphNode @from, IGraphNode to, CancellationToken cancellationToken)
        {
            return await Task.Factory.StartNew(() => Link(data, from, to), cancellationToken);
        }

        public async Task<T> LinkAsync<T>(IGraphNode @from, IGraphNode to, CancellationToken cancellationToken) where T : IGraphEdge
        {
            return await Task.Factory.StartNew(() => Link<T>(from, to), cancellationToken);
        }

        public void RemoveEdge<T>(params T[] edges) where T : IGraphEdge
        {
            _edges.RemoveAll(x => edges.OfType<IGraphEdge>().Contains(x));
        }

        public void RemoveEdge<T>(T edge) where T : IGraphEdge
        {
            _edges.Remove(edge);
        }

        public void RemoveNode<T>(params T[] nodes) where T : IGraphNode
        {
            foreach (T node in nodes)
            {
                RemoveNode(node);
            }
        }

        public void RemoveNode<T>(T node) where T : IGraphNode
        {
            node.UnsubscribeUpdates(OnNodeUpdated);
            OnNodeRemoved(node);

            _edges.RemoveAll(x => node.Edges.Contains(x));
            _edges.RemoveAll(x => node.BackEdges.Contains(x));

            _nodes.Remove(node);
        }

        public void ResetTrackedChanges()
        {
            _addedNodes.Clear();
            _removedNodes.Clear();
            _updatedNodes.Clear();
        }

        public void StartTrackChanges()
        {
            _trackChanges = true;
        }

        public void StopTrackChanges()
        {
            _trackChanges = false;
        }

        #endregion

        #region Methods

        protected internal void AddNode(IGraphNode node)
        {
            if (node.Graph != this)
            {
                throw new ArgumentException("node.Graph != this", nameof(node));
            }

            _nodes.Add(node);
            node.SubscribeUpdates(OnNodeUpdated);
            OnNodeAdded(node);
        }

        void IGraph.AddNode(IGraphNode node)
        {
            AddNode(node);
        }

        private void OnNodeAdded(IGraphNode node)
        {
            if (_trackChanges)
            {
                _addedNodes.Add(node);
            }
        }

        private void OnNodeRemoved<T>(T node) where T : IGraphNode
        {
            if (_trackChanges)
            {
                if (_addedNodes.Contains(node))
                {
                    _addedNodes.Remove(node);
                }
                else if (_updatedNodes.Contains(node))
                {
                    _updatedNodes.Remove(node);
                    _removedNodes.Add(node);
                }
                else
                {
                    _removedNodes.Add(node);
                }
            }
        }

        private void OnNodeUpdated(IGraphNode node, bool isRestored)
        {
            if (_trackChanges)
            {
                if (isRestored)
                {
                    _updatedNodes.Remove(node);
                }
                else
                {
                    if (!_addedNodes.Contains(node))
                    {
                        _updatedNodes.Add(node);
                    }
                }
            }
        }

        #endregion
    }
}