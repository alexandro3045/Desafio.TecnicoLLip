/**
 * Bundle of @devexpress/dx-react-grid
 * Generated: 2023-05-05
 * Version: 4.0.3
 * License: https://js.devexpress.com/Licensing
 */

(function (global, factory) {
    typeof exports === 'object' && typeof module !== 'undefined' ? factory(exports, require('react'), require('@devexpress/dx-react-core'), require('@devexpress/dx-grid-core'), require('@devexpress/dx-core'), require('react-dom')) :
    typeof define === 'function' && define.amd ? define(['exports', 'react', '@devexpress/dx-react-core', '@devexpress/dx-grid-core', '@devexpress/dx-core', 'react-dom'], factory) :
    (global = global || self, factory((global.DevExpress = global.DevExpress || {}, global.DevExpress.DXReactGrid = {}), global.React, global.DevExpress.DXReactCore, global.DevExpress.DXGridCore, global.DevExpress.DXCore, global.ReactDOM));
}(this, (function (exports, React, dxReactCore, dxGridCore, dxCore, reactDom) { 'use strict';

    if (typeof process === "undefined") { var process = { env: {} }; }

    /******************************************************************************
    Copyright (c) Microsoft Corporation.

    Permission to use, copy, modify, and/or distribute this software for any
    purpose with or without fee is hereby granted.

    THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
    REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
    AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
    INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
    LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
    OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
    PERFORMANCE OF THIS SOFTWARE.
    ***************************************************************************** */
    /* global Reflect, Promise */

    var extendStatics = function(d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };

    function __extends(d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    }

    var __assign = function() {
        __assign = Object.assign || function __assign(t) {
            for (var s, i = 1, n = arguments.length; i < n; i++) {
                s = arguments[i];
                for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p)) t[p] = s[p];
            }
            return t;
        };
        return __assign.apply(this, arguments);
    };

    function __rest(s, e) {
        var t = {};
        for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
            t[p] = s[p];
        if (s != null && typeof Object.getOwnPropertySymbols === "function")
            for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
                if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                    t[p[i]] = s[p[i]];
            }
        return t;
    }

    function __read(o, n) {
        var m = typeof Symbol === "function" && o[Symbol.iterator];
        if (!m) return o;
        var i = m.call(o), r, ar = [], e;
        try {
            while ((n === void 0 || n-- > 0) && !(r = i.next()).done) ar.push(r.value);
        }
        catch (error) { e = { error: error }; }
        finally {
            try {
                if (r && !r.done && (m = i["return"])) m.call(i);
            }
            finally { if (e) throw e.error; }
        }
        return ar;
    }

    function __spreadArray(to, from, pack) {
        if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
            if (ar || !(i in from)) {
                if (!ar) ar = Array.prototype.slice.call(from, 0, i);
                ar[i] = from[i];
            }
        }
        return to.concat(ar || Array.prototype.slice.call(from));
    }

    var showColumnWhenGroupedGetter = function (showColumnsWhenGrouped, columnExtensions) {
        if (columnExtensions === void 0) { columnExtensions = []; }
        var map = columnExtensions.reduce(function (acc, columnExtension) {
            acc[columnExtension.columnName] = columnExtension.showWhenGrouped;
            return acc;
        }, {});
        return function (columnName) { return map[columnName] || showColumnsWhenGrouped; };
    };
    /** @internal */
    var TableColumnsWithGrouping = React.memo(function (_a) {
        var indentColumnWidth = _a.indentColumnWidth, showColumnsWhenGrouped = _a.showColumnsWhenGrouped, columnExtensions = _a.columnExtensions;
        var tableColumnsComputed = function (_a) {
            var columns = _a.columns, tableColumns = _a.tableColumns, grouping = _a.grouping, draftGrouping = _a.draftGrouping;
            return dxGridCore.tableColumnsWithGrouping(columns, tableColumns, grouping, draftGrouping, indentColumnWidth, showColumnWhenGroupedGetter(showColumnsWhenGrouped, columnExtensions));
        };
        return (React.createElement(dxReactCore.Plugin, null,
            React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed })));
    });
    TableColumnsWithGrouping.defaultProps = {
        indentColumnWidth: 0,
    };

    var GridCoreGetters = React.memo(function (_a) {
        var rows = _a.rows, columns = _a.columns, getRowId = _a.getRowId, getCellValue = _a.getCellValue;
        return (React.createElement(dxReactCore.Plugin, null,
            React.createElement(dxReactCore.Getter, { name: "rows", value: rows }),
            React.createElement(dxReactCore.Getter, { name: "getRowId", value: dxGridCore.rowIdGetter(getRowId, rows) }),
            React.createElement(dxReactCore.Getter, { name: "columns", value: columns }),
            React.createElement(dxReactCore.Getter, { name: "getCellValue", value: dxGridCore.cellValueGetter(getCellValue, columns) })));
    });

    var TableColumnsWithDataRowsGetter = React.memo(function (_a) {
        var columnExtensions = _a.columnExtensions;
        var tableColumnsComputed = React.useCallback(function (_a) {
            var columns = _a.columns;
            return (dxGridCore.tableColumnsWithDataRows(columns, columnExtensions));
        }, [columnExtensions]);
        dxGridCore.checkTableColumnExtensions(columnExtensions);
        return (React.createElement(dxReactCore.Plugin, null,
            React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed })));
    });

    var visibleTableColumnsComputed = function (_a) {
        var tableColumns = _a.tableColumns, hiddenColumnNames = _a.hiddenColumnNames;
        return dxGridCore.visibleTableColumns(tableColumns, hiddenColumnNames);
    };
    /** @internal */
    var VisibleTableColumns = React.memo(function (_a) {
        var hiddenColumnNames = _a.hiddenColumnNames;
        return (React.createElement(dxReactCore.Plugin, null,
            React.createElement(dxReactCore.Getter, { name: "hiddenColumnNames", value: hiddenColumnNames }),
            React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: visibleTableColumnsComputed })));
    });
    VisibleTableColumns.defaultProps = {
        hiddenColumnNames: [],
    };

    /** @internal */
    var OrderedTableColumns = function (_a) {
        var order = _a.order;
        var columnsComputed = function (_a) {
            var tableColumns = _a.tableColumns;
            return dxGridCore.orderedColumns(tableColumns, order);
        };
        return (React.createElement(dxReactCore.Plugin, null,
            React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: columnsComputed })));
    };
    OrderedTableColumns.defaultProps = {
        order: [],
    };

    var GridCore = /*#__PURE__*/ (function (_super) {
        __extends(GridCore, _super);
        function GridCore(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                ref: {},
            };
            _this.rootRef = React.createRef();
            return _this;
        }
        GridCore.prototype.componentDidMount = function () {
            this.setState({
                ref: this.rootRef,
            });
        };
        GridCore.prototype.render = function () {
            var _a = this.props, Root = _a.rootComponent, restProps = __rest(_a, ["rootComponent"]);
            var ref = this.state.ref;
            return (React.createElement(dxReactCore.Plugin, null,
                React.createElement(dxReactCore.Getter, { name: "skip", value: 0 }),
                React.createElement(dxReactCore.Getter, { name: "loadedRowsStart", value: 0 }),
                React.createElement(dxReactCore.Getter, { name: "rootRef", value: ref }),
                React.createElement(GridCoreGetters, __assign({}, restProps)),
                React.createElement(dxReactCore.Template, { name: "root" },
                    React.createElement(Root, { rootRef: this.rootRef },
                        React.createElement(dxReactCore.TemplatePlaceholder, { name: "header" }),
                        React.createElement(dxReactCore.TemplatePlaceholder, { name: "body" }),
                        React.createElement(dxReactCore.TemplatePlaceholder, { name: "footer" })))));
        };
        return GridCore;
    }(React.PureComponent));

    var GridBase = function (_a) {
        var rows = _a.rows, columns = _a.columns, getRowId = _a.getRowId, getCellValue = _a.getCellValue, rootComponent = _a.rootComponent, children = _a.children;
        return (React.createElement(dxReactCore.PluginHost, null,
            React.createElement(GridCore, { rows: rows, columns: columns, getRowId: getRowId, getCellValue: getCellValue, rootComponent: rootComponent }),
            children));
    };
    /***
     * The Grid is a root container component designed to process and display data specified via
     * the `rows` property. You can configure columns using the `columns` property. The Grid's
     * functionality  is implemented in several plugins specified as child components.
     * See the plugins concept for details.
     * */
    var Grid = GridBase;

    var pluginDependencies = [
        { name: 'TableColumnVisibility' },
        { name: 'Toolbar' },
    ];
    var ColumnChooserBase = /*#__PURE__*/ (function (_super) {
        __extends(ColumnChooserBase, _super);
        function ColumnChooserBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                visible: false,
            };
            _this.handleToggle = _this.handleToggle.bind(_this);
            _this.handleHide = _this.handleHide.bind(_this);
            _this.setButtonRef = _this.setButtonRef.bind(_this);
            return _this;
        }
        ColumnChooserBase.prototype.setButtonRef = function (button) {
            this.button = button;
        };
        ColumnChooserBase.prototype.handleToggle = function () {
            var visible = this.state.visible;
            this.setState({ visible: !visible });
        };
        ColumnChooserBase.prototype.handleHide = function () {
            this.setState({ visible: false });
        };
        ColumnChooserBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, Overlay = _a.overlayComponent, Container = _a.containerComponent, Item = _a.itemComponent, ToggleButton = _a.toggleButtonComponent, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(messages);
            var visible = this.state.visible;
            return (React.createElement(dxReactCore.Plugin, { name: "ColumnChooser", dependencies: pluginDependencies },
                React.createElement(dxReactCore.Template, { name: "toolbarContent" },
                    React.createElement(dxReactCore.TemplatePlaceholder, null),
                    React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                        var columns = _a.columns, hiddenColumnNames = _a.hiddenColumnNames, isColumnTogglingEnabled = _a.isColumnTogglingEnabled;
                        var toggleColumnVisibility = _b.toggleColumnVisibility;
                        return (React.createElement(React.Fragment, null,
                            React.createElement(ToggleButton, { buttonRef: _this.setButtonRef, onToggle: _this.handleToggle, getMessage: getMessage, active: visible }),
                            React.createElement(Overlay, { visible: visible, target: _this.button, onHide: _this.handleHide },
                                React.createElement(Container, null, dxGridCore.columnChooserItems(columns, hiddenColumnNames)
                                    .map(function (item) {
                                    var columnName = item.column.name;
                                    var togglingEnabled = isColumnTogglingEnabled(columnName);
                                    return (React.createElement(Item, { key: columnName, item: item, disabled: !togglingEnabled, onToggle: function () { return toggleColumnVisibility(columnName); } }));
                                })))));
                    }))));
        };
        ColumnChooserBase.defaultProps = {
            messages: {},
        };
        ColumnChooserBase.components = {
            overlayComponent: 'Overlay',
            containerComponent: 'Container',
            itemComponent: 'Item',
            toggleButtonComponent: 'ToggleButton',
        };
        return ColumnChooserBase;
    }(React.PureComponent));
    /***
     * The ColumnChooser plugin allows a user to toggle grid columns' visibility at runtime.
     * The column chooser lists columns with checkboxes that control a corresponding
     * column's visibility.
     * */
    var ColumnChooser = ColumnChooserBase;

    var columnExtensionValueGetter = function (columnExtensions, defaultValue) { return (dxGridCore.getColumnExtensionValueGetter(columnExtensions, 'filteringEnabled', defaultValue)); };
    var filterExpressionComputed = function (_a) {
        var filters = _a.filters, filterExpressionValue = _a.filterExpression;
        return dxGridCore.filterExpression(filters, filterExpressionValue);
    };
    var FilteringStateBase = /*#__PURE__*/ (function (_super) {
        __extends(FilteringStateBase, _super);
        function FilteringStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                filters: props.filters || props.defaultFilters,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                filters: function () {
                    var onFiltersChange = _this.props.onFiltersChange;
                    return onFiltersChange;
                },
            });
            _this.changeColumnFilter = stateHelper.applyFieldReducer
                .bind(stateHelper, 'filters', dxGridCore.changeColumnFilter);
            return _this;
        }
        // tslint:disable-next-line:member-ordering
        FilteringStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.filters, filters = _a === void 0 ? prevState.filters : _a;
            return {
                filters: filters,
            };
        };
        FilteringStateBase.prototype.render = function () {
            var filters = this.state.filters;
            var _a = this.props, columnExtensions = _a.columnExtensions, columnFilteringEnabled = _a.columnFilteringEnabled;
            return (React.createElement(dxReactCore.Plugin, { name: "FilteringState" },
                React.createElement(dxReactCore.Getter, { name: "filters", value: filters }),
                React.createElement(dxReactCore.Getter, { name: "filterExpression", computed: filterExpressionComputed }),
                React.createElement(dxReactCore.Getter, { name: "isColumnFilteringEnabled", value: columnExtensionValueGetter(columnExtensions, columnFilteringEnabled) }),
                React.createElement(dxReactCore.Action, { name: "changeColumnFilter", action: this.changeColumnFilter })));
        };
        FilteringStateBase.defaultProps = {
            defaultFilters: [],
            columnFilteringEnabled: true,
        };
        return FilteringStateBase;
    }(React.PureComponent));
    /** A plugin that manages the filtering state. */
    var FilteringState = FilteringStateBase;

    var pluginDependencies$1 = [
        { name: 'FilteringState', optional: true },
        { name: 'SearchState', optional: true },
    ];
    var getCollapsedRowsComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.filteredCollapsedRowsGetter(rows);
    };
    var unwrappedRowsComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.unwrappedFilteredRows(rows);
    };
    var IntegratedFilteringBase = /*#__PURE__*/ (function (_super) {
        __extends(IntegratedFilteringBase, _super);
        function IntegratedFilteringBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        IntegratedFilteringBase.prototype.render = function () {
            var columnExtensions = this.props.columnExtensions;
            var getColumnPredicate = function (columnName) { return dxGridCore.getColumnExtension(columnExtensions, columnName).predicate; };
            var rowsComputed = function (_a) {
                var rows = _a.rows, filterExpression = _a.filterExpression, getCellValue = _a.getCellValue, getRowLevelKey = _a.getRowLevelKey, getCollapsedRows = _a.getCollapsedRows;
                return dxGridCore.filteredRows(rows, filterExpression, getCellValue, getColumnPredicate, getRowLevelKey, getCollapsedRows);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "IntegratedFiltering", dependencies: pluginDependencies$1 },
                React.createElement(dxReactCore.Getter, { name: "rows", computed: rowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "getCollapsedRows", computed: getCollapsedRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: unwrappedRowsComputed })));
        };
        return IntegratedFilteringBase;
    }(React.PureComponent));
    IntegratedFilteringBase.defaultPredicate = dxGridCore.defaultFilterPredicate;
    var IntegratedFiltering = IntegratedFilteringBase;

    var columnExtensionValueGetter$1 = function (columnExtensions, defaultValue) { return dxGridCore.getColumnExtensionValueGetter(columnExtensions, 'editingEnabled', defaultValue); };
    var EditingStateBase = /*#__PURE__*/ (function (_super) {
        __extends(EditingStateBase, _super);
        function EditingStateBase(props) {
            var _this = _super.call(this, props) || this;
            var rowChanges = props.rowChanges || props.defaultRowChanges;
            var addedRows = props.addedRows || props.defaultAddedRows;
            var getRowChanges = function () {
                var stateRowChanges = _this.state.rowChanges;
                return stateRowChanges;
            };
            var getAddedRows = function () {
                var stateAddedRows = _this.state.addedRows;
                return stateAddedRows;
            };
            _this.state = {
                addedRows: addedRows,
                rowChanges: rowChanges,
                editingRowIds: props.editingRowIds || props.defaultEditingRowIds,
                deletedRowIds: props.deletedRowIds || props.defaultDeletedRowIds,
                editingCells: props.editingCells || props.defaultEditingCells,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                editingRowIds: function () {
                    var onEditingRowIdsChange = _this.props.onEditingRowIdsChange;
                    return onEditingRowIdsChange;
                },
                editingCells: function () {
                    var onEditingCellsChange = _this.props.onEditingCellsChange;
                    return onEditingCellsChange;
                },
                addedRows: function () {
                    var onAddedRowsChange = _this.props.onAddedRowsChange;
                    return onAddedRowsChange;
                },
                rowChanges: function () {
                    var onRowChangesChange = _this.props.onRowChangesChange;
                    return onRowChangesChange;
                },
                deletedRowIds: function () {
                    var onDeletedRowIdsChange = _this.props.onDeletedRowIdsChange;
                    return onDeletedRowIdsChange;
                },
            });
            _this.startEditRows = stateHelper.applyFieldReducer
                .bind(stateHelper, 'editingRowIds', dxGridCore.startEditRows);
            _this.stopEditRows = stateHelper.applyFieldReducer
                .bind(stateHelper, 'editingRowIds', dxGridCore.stopEditRows);
            _this.startEditCells = stateHelper.applyFieldReducer
                .bind(stateHelper, 'editingCells', dxGridCore.startEditCells);
            _this.stopEditCells = stateHelper.applyFieldReducer
                .bind(stateHelper, 'editingCells', dxGridCore.stopEditCells);
            _this.changeRow = stateHelper.applyFieldReducer
                .bind(stateHelper, 'rowChanges', dxGridCore.changeRow);
            _this.cancelChangedRows = stateHelper.applyFieldReducer
                .bind(stateHelper, 'rowChanges', dxGridCore.cancelChanges);
            _this.commitChangedRows = function (_a) {
                var rowIds = _a.rowIds;
                var onCommitChanges = _this.props.onCommitChanges;
                onCommitChanges({
                    changed: dxGridCore.changedRowsByIds(getRowChanges(), rowIds),
                });
                _this.cancelChangedRows({ rowIds: rowIds });
            };
            _this.addRow = stateHelper.applyFieldReducer
                .bind(stateHelper, 'addedRows', dxGridCore.addRow);
            _this.changeAddedRow = stateHelper.applyFieldReducer
                .bind(stateHelper, 'addedRows', dxGridCore.changeAddedRow);
            _this.cancelAddedRows = stateHelper.applyFieldReducer
                .bind(stateHelper, 'addedRows', dxGridCore.cancelAddedRows);
            _this.commitAddedRows = function (_a) {
                var rowIds = _a.rowIds;
                var onCommitChanges = _this.props.onCommitChanges;
                onCommitChanges({
                    added: dxGridCore.addedRowsByIds(getAddedRows(), rowIds),
                });
                _this.cancelAddedRows({ rowIds: rowIds });
            };
            _this.deleteRows = stateHelper.applyFieldReducer
                .bind(stateHelper, 'deletedRowIds', dxGridCore.deleteRows);
            _this.cancelDeletedRows = stateHelper.applyFieldReducer
                .bind(stateHelper, 'deletedRowIds', dxGridCore.cancelDeletedRows);
            _this.commitDeletedRows = function (_a) {
                var rowIds = _a.rowIds;
                var onCommitChanges = _this.props.onCommitChanges;
                onCommitChanges({ deleted: rowIds });
                _this.cancelDeletedRows({ rowIds: rowIds });
            };
            return _this;
        }
        EditingStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.editingRowIds, editingRowIds = _a === void 0 ? prevState.editingRowIds : _a, _b = nextProps.editingCells, editingCells = _b === void 0 ? prevState.editingCells : _b, _c = nextProps.rowChanges, rowChanges = _c === void 0 ? prevState.rowChanges : _c, _d = nextProps.addedRows, addedRows = _d === void 0 ? prevState.addedRows : _d, _e = nextProps.deletedRowIds, deletedRowIds = _e === void 0 ? prevState.deletedRowIds : _e;
            return {
                editingRowIds: editingRowIds,
                editingCells: editingCells,
                rowChanges: rowChanges,
                addedRows: addedRows,
                deletedRowIds: deletedRowIds,
            };
        };
        EditingStateBase.prototype.render = function () {
            var _a = this.props, createRowChange = _a.createRowChange, columnExtensions = _a.columnExtensions, columnEditingEnabled = _a.columnEditingEnabled;
            var _b = this.state, editingRowIds = _b.editingRowIds, editingCells = _b.editingCells, rowChanges = _b.rowChanges, addedRows = _b.addedRows, deletedRowIds = _b.deletedRowIds;
            return (React.createElement(dxReactCore.Plugin, { name: "EditingState" },
                React.createElement(dxReactCore.Getter, { name: "createRowChange", value: dxGridCore.createRowChangeGetter(createRowChange, columnExtensions) }),
                React.createElement(dxReactCore.Getter, { name: "editingRowIds", value: editingRowIds }),
                React.createElement(dxReactCore.Action, { name: "startEditRows", action: this.startEditRows }),
                React.createElement(dxReactCore.Action, { name: "stopEditRows", action: this.stopEditRows }),
                React.createElement(dxReactCore.Getter, { name: "editingCells", value: editingCells }),
                React.createElement(dxReactCore.Action, { name: "startEditCells", action: this.startEditCells }),
                React.createElement(dxReactCore.Action, { name: "stopEditCells", action: this.stopEditCells }),
                React.createElement(dxReactCore.Getter, { name: "rowChanges", value: rowChanges }),
                React.createElement(dxReactCore.Action, { name: "changeRow", action: this.changeRow }),
                React.createElement(dxReactCore.Action, { name: "cancelChangedRows", action: this.cancelChangedRows }),
                React.createElement(dxReactCore.Action, { name: "commitChangedRows", action: this.commitChangedRows }),
                React.createElement(dxReactCore.Getter, { name: "addedRows", value: addedRows }),
                React.createElement(dxReactCore.Action, { name: "addRow", action: this.addRow }),
                React.createElement(dxReactCore.Action, { name: "changeAddedRow", action: this.changeAddedRow }),
                React.createElement(dxReactCore.Action, { name: "cancelAddedRows", action: this.cancelAddedRows }),
                React.createElement(dxReactCore.Action, { name: "commitAddedRows", action: this.commitAddedRows }),
                React.createElement(dxReactCore.Getter, { name: "deletedRowIds", value: deletedRowIds }),
                React.createElement(dxReactCore.Action, { name: "deleteRows", action: this.deleteRows }),
                React.createElement(dxReactCore.Action, { name: "cancelDeletedRows", action: this.cancelDeletedRows }),
                React.createElement(dxReactCore.Action, { name: "commitDeletedRows", action: this.commitDeletedRows }),
                React.createElement(dxReactCore.Getter, { name: "isColumnEditingEnabled", value: columnExtensionValueGetter$1(columnExtensions, columnEditingEnabled) })));
        };
        EditingStateBase.defaultProps = {
            columnEditingEnabled: true,
            defaultEditingRowIds: [],
            defaultEditingCells: [],
            defaultRowChanges: {},
            defaultAddedRows: [],
            defaultDeletedRowIds: [],
        };
        return EditingStateBase;
    }(React.PureComponent));
    /***
     * A plugin that manages grid rows' editing state. It arranges grid rows
     * by different lists depending on a row's state.
     * */
    var EditingState = EditingStateBase;

    var PagingStateBase = /*#__PURE__*/ (function (_super) {
        __extends(PagingStateBase, _super);
        function PagingStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                currentPage: props.currentPage || props.defaultCurrentPage,
                pageSize: props.pageSize !== undefined ? props.pageSize : props.defaultPageSize,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                currentPage: function () {
                    var onCurrentPageChange = _this.props.onCurrentPageChange;
                    return onCurrentPageChange;
                },
                pageSize: function () {
                    var onPageSizeChange = _this.props.onPageSizeChange;
                    return onPageSizeChange;
                },
            });
            _this.setCurrentPage = stateHelper.applyFieldReducer
                .bind(stateHelper, 'currentPage', dxGridCore.setCurrentPage);
            _this.setPageSize = stateHelper.applyFieldReducer
                .bind(stateHelper, 'pageSize', dxGridCore.setPageSize);
            return _this;
        }
        PagingStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.currentPage, currentPage = _a === void 0 ? prevState.currentPage : _a, _b = nextProps.pageSize, pageSize = _b === void 0 ? prevState.pageSize : _b;
            return {
                currentPage: currentPage,
                pageSize: pageSize,
            };
        };
        PagingStateBase.prototype.render = function () {
            var _a = this.state, pageSize = _a.pageSize, currentPage = _a.currentPage;
            return (React.createElement(dxReactCore.Plugin, { name: "PagingState" },
                React.createElement(dxReactCore.Getter, { name: "currentPage", value: currentPage }),
                React.createElement(dxReactCore.Getter, { name: "pageSize", value: pageSize }),
                React.createElement(dxReactCore.Action, { name: "setCurrentPage", action: this.setCurrentPage }),
                React.createElement(dxReactCore.Action, { name: "setPageSize", action: this.setPageSize })));
        };
        PagingStateBase.defaultProps = {
            defaultPageSize: 10,
            defaultCurrentPage: 0,
        };
        return PagingStateBase;
    }(React.PureComponent));
    /***
     * A plugin that manages the paging state. It controls the total page count depending on the
     * total row count and the specified page size, controls the currently selected page number
     * and changes it in response to the corresponding actions.
     * */
    var PagingState = PagingStateBase;

    var pluginDependencies$2 = [
        { name: 'PagingState' },
    ];
    var rowsWithHeadersComputed = function (_a) {
        var rows = _a.rows, pageSize = _a.pageSize, getRowLevelKey = _a.getRowLevelKey;
        return dxGridCore.rowsWithPageHeaders(rows, pageSize, getRowLevelKey);
    };
    var totalCountComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.rowCount(rows);
    };
    var paginatedRowsComputed = function (_a) {
        var rows = _a.rows, pageSize = _a.pageSize, page = _a.currentPage;
        return dxGridCore.paginatedRows(rows, pageSize, page);
    };
    var currentPageComputed = function (_a, _b) {
        var page = _a.currentPage, totalCount = _a.totalCount, pageSize = _a.pageSize;
        var setCurrentPage = _b.setCurrentPage;
        return dxGridCore.currentPage(page, totalCount, pageSize, setCurrentPage);
    };
    // eslint-disable-next-line react/prefer-stateless-function
    var IntegratedPagingBase = /*#__PURE__*/ (function (_super) {
        __extends(IntegratedPagingBase, _super);
        function IntegratedPagingBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        IntegratedPagingBase.prototype.render = function () {
            return (React.createElement(dxReactCore.Plugin, { name: "IntegratedPaging", dependencies: pluginDependencies$2 },
                React.createElement(dxReactCore.Getter, { name: "rows", computed: rowsWithHeadersComputed }),
                React.createElement(dxReactCore.Getter, { name: "totalCount", computed: totalCountComputed }),
                React.createElement(dxReactCore.Getter, { name: "currentPage", computed: currentPageComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: paginatedRowsComputed })));
        };
        return IntegratedPagingBase;
    }(React.PureComponent));
    /***
     * A plugin that performs built-in data paging. It also changes the current page if the provided
     * one cannot be applied due to fewer available pages.
     * */
    var IntegratedPaging = IntegratedPagingBase;

    var pluginDependencies$3 = [
        { name: 'PagingState' },
    ];
    var CustomPagingBase = /*#__PURE__*/ (function (_super) {
        __extends(CustomPagingBase, _super);
        function CustomPagingBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        CustomPagingBase.prototype.render = function () {
            var totalCount = this.props.totalCount;
            return (React.createElement(dxReactCore.Plugin, { name: "CustomPaging", dependencies: pluginDependencies$3 },
                React.createElement(dxReactCore.Getter, { name: "totalCount", value: totalCount })));
        };
        CustomPagingBase.defaultProps = {
            totalCount: 0,
        };
        return CustomPagingBase;
    }(React.PureComponent));
    /** A plugin that allows implementing a custom totalCount calculation logic. */
    var CustomPaging = CustomPagingBase;

    var dependencies = [
        { name: 'SortingState', optional: true },
    ];
    var columnExtensionValueGetter$2 = function (columnExtensions, defaultValue) { return dxGridCore.getColumnExtensionValueGetter(columnExtensions, 'groupingEnabled', defaultValue); };
    var GroupingStateBase = /*#__PURE__*/ (function (_super) {
        __extends(GroupingStateBase, _super);
        function GroupingStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                grouping: props.grouping || props.defaultGrouping,
                draftGrouping: null,
                expandedGroups: props.expandedGroups || props.defaultExpandedGroups,
            };
            _this.stateHelper = dxReactCore.createStateHelper(_this, {
                grouping: function () {
                    var onGroupingChange = _this.props.onGroupingChange;
                    return onGroupingChange;
                },
                expandedGroups: function () {
                    var onExpandedGroupsChange = _this.props.onExpandedGroupsChange;
                    return onExpandedGroupsChange;
                },
            });
            _this.changeColumnGrouping = _this.changeColumnGrouping.bind(_this);
            _this.toggleGroupExpanded = _this.stateHelper.applyReducer
                .bind(_this.stateHelper, dxGridCore.toggleExpandedGroups);
            _this.draftColumnGrouping = _this.stateHelper.applyReducer
                .bind(_this.stateHelper, dxGridCore.draftColumnGrouping);
            _this.cancelColumnGroupingDraft = _this.stateHelper.applyReducer
                .bind(_this.stateHelper, dxGridCore.cancelColumnGroupingDraft);
            _this.changeColumnSorting = _this.changeColumnSorting.bind(_this);
            return _this;
        }
        GroupingStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.grouping, grouping = _a === void 0 ? prevState.grouping : _a, _b = nextProps.expandedGroups, expandedGroups = _b === void 0 ? prevState.expandedGroups : _b;
            return {
                grouping: grouping,
                expandedGroups: expandedGroups,
            };
        };
        GroupingStateBase.prototype.changeColumnSorting = function (_a, _b, _c) {
            var columnName = _a.columnName, keepOther = _a.keepOther, restParams = __rest(_a, ["columnName", "keepOther"]);
            var sorting = _b.sorting;
            var changeColumnSorting = _c.changeColumnSorting;
            var grouping = this.state.grouping;
            var groupingIndex = grouping
                .findIndex(function (columnGrouping) { return columnGrouping.columnName === columnName; });
            if (groupingIndex === -1) {
                changeColumnSorting(__assign({ columnName: columnName, keepOther: keepOther || grouping.map(function (columnGrouping) { return columnGrouping.columnName; }) }, restParams));
                return false;
            }
            var sortIndex = dxGridCore.adjustSortIndex(groupingIndex, grouping, sorting);
            changeColumnSorting(__assign({ columnName: columnName, sortIndex: sortIndex, keepOther: true }, restParams));
            return false;
        };
        GroupingStateBase.prototype.changeColumnGrouping = function (_a, getters, actions) {
            var columnName = _a.columnName, groupIndex = _a.groupIndex;
            this.stateHelper.applyReducer(dxGridCore.changeColumnGrouping, { columnName: columnName, groupIndex: groupIndex }, function (nextState, state) {
                var grouping = nextState.grouping;
                var prevGrouping = state.grouping;
                var sorting = getters.sorting;
                var changeColumnSorting = actions.changeColumnSorting;
                if (!sorting)
                    return;
                var columnSortingIndex = sorting
                    .findIndex(function (columnSorting) { return columnSorting.columnName === columnName; });
                var prevGroupingIndex = prevGrouping
                    .findIndex(function (columnGrouping) { return columnGrouping.columnName === columnName; });
                var groupingIndex = grouping
                    .findIndex(function (columnGrouping) { return columnGrouping.columnName === columnName; });
                if (columnSortingIndex === -1
                    || (prevGroupingIndex === prevGrouping.length - 1 && groupingIndex === -1))
                    return;
                var sortIndex = dxGridCore.adjustSortIndex(groupingIndex === -1 ? grouping.length : groupingIndex, grouping, sorting);
                if (columnSortingIndex === sortIndex)
                    return;
                changeColumnSorting(__assign({ sortIndex: sortIndex, keepOther: true }, sorting[columnSortingIndex]));
            });
        };
        GroupingStateBase.prototype.render = function () {
            var _a = this.state, grouping = _a.grouping, draftGrouping = _a.draftGrouping, expandedGroups = _a.expandedGroups;
            var _b = this.props, columnExtensions = _b.columnExtensions, columnGroupingEnabled = _b.columnGroupingEnabled;
            return (React.createElement(dxReactCore.Plugin, { name: "GroupingState", dependencies: dependencies },
                React.createElement(dxReactCore.Getter, { name: "grouping", value: grouping }),
                React.createElement(dxReactCore.Getter, { name: "draftGrouping", value: draftGrouping || grouping }),
                React.createElement(dxReactCore.Getter, { name: "isColumnGroupingEnabled", value: columnExtensionValueGetter$2(columnExtensions, columnGroupingEnabled) }),
                React.createElement(dxReactCore.Action, { name: "changeColumnGrouping", action: this.changeColumnGrouping }),
                React.createElement(dxReactCore.Action, { name: "draftColumnGrouping", action: this.draftColumnGrouping }),
                React.createElement(dxReactCore.Action, { name: "cancelColumnGroupingDraft", action: this.cancelColumnGroupingDraft }),
                React.createElement(dxReactCore.Getter, { name: "expandedGroups", value: expandedGroups }),
                React.createElement(dxReactCore.Action, { name: "toggleGroupExpanded", action: this.toggleGroupExpanded }),
                React.createElement(dxReactCore.Action, { name: "changeColumnSorting", action: this.changeColumnSorting })));
        };
        GroupingStateBase.defaultProps = {
            defaultGrouping: [],
            defaultExpandedGroups: [],
            columnGroupingEnabled: true,
        };
        return GroupingStateBase;
    }(React.PureComponent));
    /***
     * A plugin that manages the grouping state. It lists columns used for grouping and stores
     * information about expanded/collapsed groups.
     * */
    var GroupingState = GroupingStateBase;

    var pluginDependencies$4 = [
        { name: 'GroupingState' },
    ];
    var getCollapsedRowsComputed$1 = function (_a) {
        var getCollapsedRows = _a.getCollapsedRows;
        return dxGridCore.groupCollapsedRowsGetter(getCollapsedRows);
    };
    var expandedGroupedRowsComputed = function (_a) {
        var rows = _a.rows, grouping = _a.grouping, expandedGroups = _a.expandedGroups, isExporting = _a.isExporting;
        return dxGridCore.expandedGroupRows(rows, grouping, expandedGroups, isExporting);
    };
    var IntegratedGroupingBase = /*#__PURE__*/ (function (_super) {
        __extends(IntegratedGroupingBase, _super);
        function IntegratedGroupingBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        IntegratedGroupingBase.prototype.render = function () {
            var columnExtensions = this.props.columnExtensions;
            var getColumnCriteria = function (columnName) { return dxGridCore.getColumnExtension(columnExtensions, columnName).criteria; };
            var groupedRowsComputed = function (_a) {
                var rows = _a.rows, grouping = _a.grouping, getCellValue = _a.getCellValue;
                return dxGridCore.groupedRows(rows, grouping, getCellValue, getColumnCriteria);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "IntegratedGrouping", dependencies: pluginDependencies$4 },
                React.createElement(dxReactCore.Getter, { name: "isGroupRow", value: dxGridCore.groupRowChecker }),
                React.createElement(dxReactCore.Getter, { name: "getRowLevelKey", value: dxGridCore.groupRowLevelKeyGetter }),
                React.createElement(dxReactCore.Getter, { name: "getCollapsedRows", computed: getCollapsedRowsComputed$1 }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: groupedRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: expandedGroupedRowsComputed })));
        };
        return IntegratedGroupingBase;
    }(React.PureComponent));
    /* tslint:disable: max-line-length */
    /** A plugin that performs built-in grouping and group expanding/collapsing. */
    var IntegratedGrouping = IntegratedGroupingBase;
    /* tslint:enable: max-line-length */

    var pluginDependencies$5 = [
        { name: 'GroupingState' },
    ];
    var getCollapsedRowsComputed$2 = function (_a) {
        var getCollapsedRows = _a.getCollapsedRows;
        return dxGridCore.groupCollapsedRowsGetter(getCollapsedRows);
    };
    var expandedGroupedRowsComputed$1 = function (_a) {
        var rows = _a.rows, grouping = _a.grouping, expandedGroups = _a.expandedGroups, isExporting = _a.isExporting;
        return dxGridCore.expandedGroupRows(rows, grouping, expandedGroups, isExporting);
    };
    var getRowIdComputed = function (_a) {
        var getRowId = _a.getRowId, rows = _a.rows;
        return dxGridCore.customGroupingRowIdGetter(getRowId, rows);
    };
    var CustomGroupingBase = /*#__PURE__*/ (function (_super) {
        __extends(CustomGroupingBase, _super);
        function CustomGroupingBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        CustomGroupingBase.prototype.render = function () {
            var _a = this.props, getChildGroups = _a.getChildGroups, appliedGrouping = _a.grouping, appliedExpandedGroups = _a.expandedGroups;
            var groupedRowsComputed = function (_a) {
                var rows = _a.rows, grouping = _a.grouping;
                return dxGridCore.customGroupedRows(rows, grouping, getChildGroups);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "CustomGrouping", dependencies: pluginDependencies$5 },
                appliedGrouping && (React.createElement(dxReactCore.Getter, { name: "grouping", value: appliedGrouping })),
                appliedExpandedGroups && (React.createElement(dxReactCore.Getter, { name: "expandedGroups", value: appliedExpandedGroups })),
                React.createElement(dxReactCore.Getter, { name: "isGroupRow", value: dxGridCore.groupRowChecker }),
                React.createElement(dxReactCore.Getter, { name: "getRowLevelKey", value: dxGridCore.groupRowLevelKeyGetter }),
                React.createElement(dxReactCore.Getter, { name: "getCollapsedRows", computed: getCollapsedRowsComputed$2 }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: groupedRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "getRowId", computed: getRowIdComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: expandedGroupedRowsComputed$1 })));
        };
        return CustomGroupingBase;
    }(React.PureComponent));
    // tslint:disable-next-line: max-line-length
    /** A plugin that converts custom formatted grouped data to a supported format and performs local group expanding/collapsing. */
    var CustomGrouping = CustomGroupingBase;

    var SelectionStateBase = /*#__PURE__*/ (function (_super) {
        __extends(SelectionStateBase, _super);
        function SelectionStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                selection: props.selection || props.defaultSelection,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                selection: function () {
                    var onSelectionChange = _this.props.onSelectionChange;
                    return onSelectionChange;
                },
            });
            _this.toggleSelection = stateHelper.applyFieldReducer
                .bind(stateHelper, 'selection', dxGridCore.toggleSelection);
            return _this;
        }
        SelectionStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.selection, selection = _a === void 0 ? prevState.selection : _a;
            return {
                selection: selection,
            };
        };
        SelectionStateBase.prototype.render = function () {
            var selection = this.state.selection;
            return (React.createElement(dxReactCore.Plugin, { name: "SelectionState" },
                React.createElement(dxReactCore.Getter, { name: "selection", value: selection }),
                React.createElement(dxReactCore.Action, { name: "toggleSelection", action: this.toggleSelection })));
        };
        SelectionStateBase.defaultProps = {
            defaultSelection: [],
        };
        return SelectionStateBase;
    }(React.PureComponent));
    /** A plugin that manages the selection state. */
    var SelectionState = SelectionStateBase;

    var rowsWithAvailableToSelectComputed = function (_a) {
        var rows = _a.rows, getRowId = _a.getRowId, isGroupRow = _a.isGroupRow;
        return dxGridCore.rowsWithAvailableToSelect(rows, getRowId, isGroupRow);
    };
    var allSelectedComputed = function (_a) {
        var rows = _a.rows, selection = _a.selection;
        return dxGridCore.allSelected(rows, selection);
    };
    var someSelectedComputed = function (_a) {
        var rows = _a.rows, selection = _a.selection;
        return dxGridCore.someSelected(rows, selection);
    };
    var selectAllAvailableComputed = function (_a) {
        var availableToSelect = _a.rows.availableToSelect;
        return !!availableToSelect.length;
    };
    var toggleSelectAll = function (state, _a, _b) {
        var availableToSelect = _a.rows.availableToSelect;
        var toggleSelection = _b.toggleSelection;
        toggleSelection({ state: state, rowIds: availableToSelect });
    };
    var unwrapRowsComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.unwrapSelectedRows(rows);
    };
    var pluginDependencies$6 = [
        { name: 'SelectionState' },
    ];
    // eslint-disable-next-line react/prefer-stateless-function
    var IntegratedSelectionBase = /*#__PURE__*/ (function (_super) {
        __extends(IntegratedSelectionBase, _super);
        function IntegratedSelectionBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        IntegratedSelectionBase.prototype.render = function () {
            return (React.createElement(dxReactCore.Plugin, { name: "IntegratedSelection", dependencies: pluginDependencies$6 },
                React.createElement(dxReactCore.Getter, { name: "rows", computed: rowsWithAvailableToSelectComputed }),
                React.createElement(dxReactCore.Getter, { name: "allSelected", computed: allSelectedComputed }),
                React.createElement(dxReactCore.Getter, { name: "someSelected", computed: someSelectedComputed }),
                React.createElement(dxReactCore.Getter, { name: "selectAllAvailable", computed: selectAllAvailableComputed }),
                React.createElement(dxReactCore.Action, { name: "toggleSelectAll", action: toggleSelectAll }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: unwrapRowsComputed })));
        };
        return IntegratedSelectionBase;
    }(React.PureComponent));
    /* tslint:disable: max-line-length */
    /** A plugin that performs built-in selection. */
    var IntegratedSelection = IntegratedSelectionBase;
    /* tslint:enable: max-line-length */

    var columnExtensionValueGetter$3 = function (columnExtensions, defaultValue) { return dxGridCore.getColumnExtensionValueGetter(columnExtensions, 'sortingEnabled', defaultValue); };
    var SortingStateBase = /*#__PURE__*/ (function (_super) {
        __extends(SortingStateBase, _super);
        function SortingStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                sorting: props.sorting || props.defaultSorting,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                sorting: function () {
                    var onSortingChange = _this.props.onSortingChange;
                    return onSortingChange;
                },
            });
            _this.changeColumnSorting = stateHelper.applyReducer
                .bind(stateHelper, function (prevState, payload) {
                var _a = _this.props.sorting, sorting = _a === void 0 ? prevState.sorting : _a;
                var persistentSortedColumns = dxGridCore.getPersistentSortedColumns(sorting, props.columnExtensions);
                var keepOther = dxGridCore.calculateKeepOther(prevState.sorting, payload.keepOther, persistentSortedColumns);
                return dxGridCore.changeColumnSorting(prevState, __assign(__assign({}, payload), { keepOther: keepOther }));
            });
            return _this;
        }
        SortingStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.sorting, sorting = _a === void 0 ? prevState.sorting : _a;
            return {
                sorting: sorting,
            };
        };
        SortingStateBase.prototype.render = function () {
            var sorting = this.state.sorting;
            var _a = this.props, columnExtensions = _a.columnExtensions, columnSortingEnabled = _a.columnSortingEnabled;
            return (React.createElement(dxReactCore.Plugin, { name: "SortingState" },
                React.createElement(dxReactCore.Getter, { name: "sorting", value: sorting }),
                React.createElement(dxReactCore.Getter, { name: "isColumnSortingEnabled", value: columnExtensionValueGetter$3(columnExtensions, columnSortingEnabled) }),
                React.createElement(dxReactCore.Action, { name: "changeColumnSorting", action: this.changeColumnSorting })));
        };
        SortingStateBase.defaultProps = {
            defaultSorting: [],
            columnSortingEnabled: true,
        };
        return SortingStateBase;
    }(React.PureComponent));
    // tslint:disable-next-line: max-line-length
    /** A plugin that manages the sorting state. It controls the list of columns that participate in sorting. */
    var SortingState = SortingStateBase;

    var pluginDependencies$7 = [
        { name: 'SortingState' },
    ];
    var IntegratedSortingBase = /*#__PURE__*/ (function (_super) {
        __extends(IntegratedSortingBase, _super);
        function IntegratedSortingBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        IntegratedSortingBase.prototype.render = function () {
            var columnExtensions = this.props.columnExtensions;
            var getColumnCompare = function (columnName) { return dxGridCore.getColumnExtension(columnExtensions, columnName).compare; };
            var rowsComputed = function (_a) {
                var rows = _a.rows, sorting = _a.sorting, getCellValue = _a.getCellValue, isGroupRow = _a.isGroupRow, getRowLevelKey = _a.getRowLevelKey;
                return dxGridCore.sortedRows(rows, sorting, getCellValue, getColumnCompare, isGroupRow, getRowLevelKey);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "IntegratedSorting", dependencies: pluginDependencies$7 },
                React.createElement(dxReactCore.Getter, { name: "rows", computed: rowsComputed })));
        };
        return IntegratedSortingBase;
    }(React.PureComponent));
    /** A plugin that performs built-in data sorting. */
    var IntegratedSorting = IntegratedSortingBase;

    var getTargetColumns = function (payload, columns) { return payload
        .filter(function (item) { return item.type === 'column'; })
        .map(function (item) { return columns.find(function (column) { return column.name === item.columnName; }); }); };
    // tslint:disable-next-line: max-line-length
    var DragDropProviderBase = /*#__PURE__*/ (function (_super) {
        __extends(DragDropProviderBase, _super);
        function DragDropProviderBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                payload: null,
                clientOffset: null,
            };
            _this.change = function (_a) {
                var payload = _a.payload, clientOffset = _a.clientOffset;
                return _this.setState({ payload: payload, clientOffset: clientOffset });
            };
            return _this;
        }
        DragDropProviderBase.prototype.componentDidMount = function () {
            this.bodyRef = document.body;
        };
        DragDropProviderBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, Container = _a.containerComponent, Column = _a.columnComponent;
            var _b = this.state, payload = _b.payload, clientOffset = _b.clientOffset;
            return (React.createElement(dxReactCore.Plugin, { name: "DragDropProvider" },
                React.createElement(dxReactCore.Getter, { name: "draggingEnabled", value: true }),
                React.createElement(dxReactCore.Template, { name: "root" },
                    React.createElement(dxReactCore.DragDropProvider, { onChange: this.change },
                        React.createElement(dxReactCore.TemplatePlaceholder, null)),
                    payload && (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                        var columns = _a.columns;
                        return (reactDom.createPortal(React.createElement(Container, { clientOffset: clientOffset }, getTargetColumns(payload, columns)
                            .map(function (column) { return (React.createElement(Column, { key: column.name, column: column })); })), _this.bodyRef));
                    })))));
        };
        DragDropProviderBase.components = {
            containerComponent: 'Container',
            columnComponent: 'Column',
        };
        return DragDropProviderBase;
    }(React.PureComponent));
    // tslint:disable-next-line: max-line-length
    /** A plugin that implements the drag-and-drop functionality and visualizes columns that are being dragged. */
    var DragDropProvider = DragDropProviderBase;

    var pluginDependencies$8 = [
        { name: 'Table' },
        { name: 'DragDropProvider', optional: true },
    ];
    var tableHeaderRowsComputed = function (_a) {
        var tableHeaderRows = _a.tableHeaderRows;
        return dxGridCore.tableHeaderRowsWithReordering(tableHeaderRows);
    };
    // tslint:disable-next-line: max-line-length
    var TableColumnReorderingRaw = /*#__PURE__*/ (function (_super) {
        __extends(TableColumnReorderingRaw, _super);
        function TableColumnReorderingRaw(props) {
            var _this = _super.call(this, props) || this;
            _this.cellDimensionGetters = {};
            _this.cellDimensions = [];
            _this.state = {
                order: props.defaultOrder,
                sourceColumnIndex: -1,
                targetColumnIndex: -1,
            };
            _this.onOver = _this.handleOver.bind(_this);
            _this.onLeave = _this.handleLeave.bind(_this);
            _this.onDrop = _this.handleDrop.bind(_this);
            return _this;
        }
        TableColumnReorderingRaw.prototype.getState = function () {
            var orderState = this.state.order;
            var _a = this.props.order, order = _a === void 0 ? orderState : _a;
            return __assign(__assign({}, this.state), { order: order });
        };
        TableColumnReorderingRaw.prototype.getDraftOrder = function () {
            var _a = this.getState(), order = _a.order, sourceColumnIndex = _a.sourceColumnIndex, targetColumnIndex = _a.targetColumnIndex;
            return dxGridCore.draftOrder(order, sourceColumnIndex, targetColumnIndex);
        };
        TableColumnReorderingRaw.prototype.getAvailableColumns = function () {
            var _this = this;
            return this.getDraftOrder()
                .filter(function (columnName) { return !!_this.cellDimensionGetters[columnName]; });
        };
        TableColumnReorderingRaw.prototype.cacheCellDimensions = function () {
            var _this = this;
            this.cellDimensions = (this.cellDimensions && this.cellDimensions.length)
                ? this.cellDimensions
                : this.getAvailableColumns()
                    .map(function (columnName) { return _this.cellDimensionGetters[columnName](); });
        };
        TableColumnReorderingRaw.prototype.resetCellDimensions = function () {
            this.cellDimensions = [];
        };
        TableColumnReorderingRaw.prototype.ensureCellDimensionGetters = function (tableColumns) {
            var _this = this;
            Object.keys(this.cellDimensionGetters)
                .forEach(function (columnName) {
                var columnIndex = tableColumns
                    .findIndex(function (_a) {
                    var type = _a.type, column = _a.column;
                    return type === dxGridCore.TABLE_DATA_TYPE && column.name === columnName;
                });
                if (columnIndex === -1) {
                    delete _this.cellDimensionGetters[columnName];
                }
            });
        };
        // tslint:disable-next-line: max-line-length
        TableColumnReorderingRaw.prototype.storeCellDimensionsGetter = function (tableColumn, getter, tableColumns) {
            if (tableColumn.type === dxGridCore.TABLE_DATA_TYPE) {
                this.cellDimensionGetters[tableColumn.column.name] = getter;
            }
            this.ensureCellDimensionGetters(tableColumns);
        };
        TableColumnReorderingRaw.prototype.handleOver = function (_a) {
            var payload = _a.payload, x = _a.clientOffset.x;
            var sourceColumnName = payload[0].columnName;
            var availableColumns = this.getAvailableColumns();
            var relativeSourceColumnIndex = availableColumns.indexOf(sourceColumnName);
            if (relativeSourceColumnIndex === -1)
                return;
            this.cacheCellDimensions();
            var cellDimensions = this.cellDimensions;
            var relativeTargetIndex = dxGridCore.getTableTargetColumnIndex(cellDimensions, x);
            if (relativeTargetIndex === -1)
                return;
            var _b = this.getState(), prevSourceColumnIndex = _b.sourceColumnIndex, prevTargetColumnIndex = _b.targetColumnIndex;
            var draftOrder = this.getDraftOrder();
            var targetColumnIndex = draftOrder.indexOf(availableColumns[relativeTargetIndex]);
            if (targetColumnIndex === prevTargetColumnIndex)
                return;
            var sourceColumnIndex = prevSourceColumnIndex === -1
                ? draftOrder.indexOf(sourceColumnName)
                : prevSourceColumnIndex;
            this.setState({
                sourceColumnIndex: sourceColumnIndex,
                targetColumnIndex: targetColumnIndex,
            });
        };
        TableColumnReorderingRaw.prototype.handleLeave = function () {
            this.setState({
                sourceColumnIndex: -1,
                targetColumnIndex: -1,
            });
            this.resetCellDimensions();
        };
        TableColumnReorderingRaw.prototype.handleDrop = function () {
            var _a = this.getState(), sourceColumnIndex = _a.sourceColumnIndex, targetColumnIndex = _a.targetColumnIndex, order = _a.order;
            var onOrderChange = this.props.onOrderChange;
            if (sourceColumnIndex === -1 && targetColumnIndex === -1)
                return;
            var nextOrder = dxGridCore.changeColumnOrder(order, {
                sourceColumnName: order[sourceColumnIndex],
                targetColumnName: order[targetColumnIndex],
            });
            this.setState({
                order: nextOrder,
                sourceColumnIndex: -1,
                targetColumnIndex: -1,
            });
            if (onOrderChange) {
                onOrderChange(nextOrder);
            }
            this.resetCellDimensions();
        };
        TableColumnReorderingRaw.prototype.render = function () {
            var _this = this;
            var _a = this.props, Container = _a.tableContainerComponent, Row = _a.rowComponent, Cell = _a.cellComponent;
            this.cellDimensionGetters = {};
            return (React.createElement(dxReactCore.Plugin, { name: "TableColumnReordering", dependencies: pluginDependencies$8 },
                React.createElement(OrderedTableColumns, { order: this.getDraftOrder() }),
                React.createElement(dxReactCore.Getter, { name: "tableHeaderRows", computed: tableHeaderRowsComputed }),
                React.createElement(dxReactCore.Template, { name: "table" }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var draggingEnabled = _a.draggingEnabled;
                    return (React.createElement(Container, __assign({}, params, { onOver: _this.onOver, onLeave: _this.onLeave, onDrop: _this.onDrop, draggingEnabled: draggingEnabled }),
                        React.createElement(dxReactCore.PlaceholderWithRef, null)));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return tableRow.type === dxGridCore.TABLE_REORDERING_TYPE;
                    } }, function (params) { return (React.createElement(Row, __assign({}, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return tableRow.type === dxGridCore.TABLE_REORDERING_TYPE;
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var tableColumns = _a.tableColumns;
                    return (React.createElement(Cell, __assign({}, params, { getCellDimensions: function (getter) { return _this.storeCellDimensionsGetter(params.tableColumn, getter, tableColumns); } })));
                })); })));
        };
        TableColumnReorderingRaw.defaultProps = {
            defaultOrder: [],
        };
        TableColumnReorderingRaw.components = {
            tableContainerComponent: 'TableContainer',
            rowComponent: 'Row',
            cellComponent: 'Cell',
        };
        return TableColumnReorderingRaw;
    }(React.PureComponent));
    var TableContainer = function (_a) {
        var onOver = _a.onOver, onLeave = _a.onLeave, onDrop = _a.onDrop, children = _a.children, draggingEnabled = _a.draggingEnabled;
        return (draggingEnabled ? (React.createElement(dxReactCore.DropTarget, { onOver: onOver, onLeave: onLeave, onDrop: onDrop }, children)) : children);
    };
    /** A plugin that manages the displayed columns' order. */
    var TableColumnReordering = dxReactCore.withComponents({ TableContainer: TableContainer })(TableColumnReorderingRaw);

    var RowPlaceholder = React.forwardRef(function (props, ref) { return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "tableRow", params: __assign(__assign({}, props), { ref: ref }) })); });
    var CellPlaceholder = function (props) { return React.createElement(dxReactCore.TemplatePlaceholder, { name: "tableCell", params: props }); };
    var tableHeaderRows = [];
    var tableBodyRowsComputed = function (_a) {
        var rows = _a.rows, getRowId = _a.getRowId, isDataLoading = _a.isDataLoading;
        return (dxGridCore.tableRowsWithDataRows(rows, getRowId, isDataLoading));
    };
    var tableFooterRows = [];
    var defaultMessages = {
        noData: 'No data',
    };
    var TableBase = /*#__PURE__*/ (function (_super) {
        __extends(TableBase, _super);
        function TableBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableBase.prototype.render = function () {
            var _a = this.props, Layout = _a.layoutComponent, Cell = _a.cellComponent, Row = _a.rowComponent, NoDataRow = _a.noDataRowComponent, NoDataCell = _a.noDataCellComponent, StubRow = _a.stubRowComponent, StubCell = _a.stubCellComponent, StubHeaderCell = _a.stubHeaderCellComponent, columnExtensions = _a.columnExtensions, messages = _a.messages, containerComponent = _a.containerComponent, tableComponent = _a.tableComponent, headComponent = _a.headComponent, bodyComponent = _a.bodyComponent, footerComponent = _a.footerComponent;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages), messages));
            return (React.createElement(dxReactCore.Plugin, { name: "Table" },
                React.createElement(dxReactCore.Getter, { name: "tableHeaderRows", value: tableHeaderRows }),
                React.createElement(dxReactCore.Getter, { name: "tableBodyRows", computed: tableBodyRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "tableFooterRows", value: tableFooterRows }),
                React.createElement(TableColumnsWithDataRowsGetter, { columnExtensions: columnExtensions }),
                React.createElement(dxReactCore.Getter, { name: "getTableCellColSpan", value: dxGridCore.tableCellColSpanGetter }),
                React.createElement(dxReactCore.Template, { name: "body" },
                    React.createElement(dxReactCore.TemplatePlaceholder, { name: "table" })),
                React.createElement(dxReactCore.Template, { name: "table" }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var headerRows = _a.tableHeaderRows, bodyRows = _a.tableBodyRows, footerRows = _a.tableFooterRows, columns = _a.tableColumns, getTableCellColSpan = _a.getTableCellColSpan;
                    return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "tableLayout", params: __assign(__assign({}, params), { tableComponent: tableComponent, headComponent: headComponent, bodyComponent: bodyComponent, footerComponent: footerComponent, containerComponent: containerComponent, headerRows: headerRows, bodyRows: bodyRows, footerRows: footerRows, columns: columns, rowComponent: RowPlaceholder, cellComponent: CellPlaceholder, getCellColSpan: getTableCellColSpan }) }));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableLayout" }, function (params) { return (React.createElement(Layout, __assign({}, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableCell" }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var headerRows = _a.tableHeaderRows;
                    return (dxGridCore.isHeaderStubTableCell(params.tableRow, headerRows)
                        ? React.createElement(StubHeaderCell, __assign({}, params))
                        : React.createElement(StubCell, __assign({}, params)));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isDataTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var getCellValue = _a.getCellValue;
                    var columnName = params.tableColumn.column.name;
                    var value = getCellValue(params.tableRow.row, columnName);
                    return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "valueFormatter", params: {
                            value: value,
                            row: params.tableRow.row,
                            column: params.tableColumn.column,
                        } }, function (content) { return (React.createElement(Cell, __assign({}, params, { row: params.tableRow.row, column: params.tableColumn.column, value: value }), content)); }));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isNoDataTableRow(tableRow);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var tableColumns = _a.tableColumns;
                    if (dxGridCore.isNoDataTableCell(params.tableColumn, tableColumns)) {
                        return (React.createElement(NoDataCell, __assign({}, params, { getMessage: getMessage })));
                    }
                    return null;
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow" }, function (params) { return (React.createElement(StubRow, __assign({}, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isDataTableRow(tableRow);
                    } }, function (params) { return (React.createElement(Row, __assign({}, params, { row: params.tableRow.row }))); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isNoDataTableRow(tableRow);
                    } }, function (params) { return React.createElement(NoDataRow, __assign({}, params)); })));
        };
        TableBase.COLUMN_TYPE = dxGridCore.TABLE_DATA_TYPE;
        TableBase.ROW_TYPE = dxGridCore.TABLE_DATA_TYPE;
        TableBase.NODATA_ROW_TYPE = dxGridCore.TABLE_NODATA_TYPE;
        TableBase.defaultProps = {
            messages: {},
        };
        TableBase.components = {
            tableComponent: 'Table',
            headComponent: 'TableHead',
            bodyComponent: 'TableBody',
            footerComponent: 'TableFooter',
            containerComponent: 'Container',
            layoutComponent: 'Layout',
            rowComponent: 'Row',
            cellComponent: 'Cell',
            noDataRowComponent: 'NoDataRow',
            noDataCellComponent: 'NoDataCell',
            stubRowComponent: 'StubRow',
            stubCellComponent: 'StubCell',
            stubHeaderCellComponent: 'StubHeaderCell',
        };
        return TableBase;
    }(React.PureComponent));
    /***
     * A plugin that renders Grid data as a table. This plugin enables you to customize
     * table rows and columns, and contains the Table Row and Table Cell components
     * that can be extended by other plugins
     * */
    var Table = TableBase;

    var TableSelectionBase = /*#__PURE__*/ (function (_super) {
        __extends(TableSelectionBase, _super);
        function TableSelectionBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableSelectionBase.prototype.render = function () {
            var _a = this.props, highlightRow = _a.highlightRow, selectByRowClick = _a.selectByRowClick, showSelectionColumn = _a.showSelectionColumn, showSelectAll = _a.showSelectAll, HeaderCell = _a.headerCellComponent, Cell = _a.cellComponent, Row = _a.rowComponent, selectionColumnWidth = _a.selectionColumnWidth;
            var tableColumnsComputed = function (_a) {
                var tableColumns = _a.tableColumns;
                return dxGridCore.tableColumnsWithSelection(tableColumns, selectionColumnWidth, showSelectionColumn);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "TableSelection", dependencies: [
                    { name: 'Table' },
                    { name: 'SelectionState' },
                    { name: 'IntegratedSelection', optional: !showSelectAll },
                ] },
                React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed }),
                highlightRow && (React.createElement(dxReactCore.Getter, { name: "highlightSelectedRow", value: true })),
                (showSelectionColumn && showSelectAll) && (React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isSelectAllTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var selectAllAvailable = _a.selectAllAvailable, allSelected = _a.allSelected, someSelected = _a.someSelected;
                    var toggleSelectAll = _b.toggleSelectAll;
                    return (React.createElement(HeaderCell, __assign({}, params, { disabled: !selectAllAvailable, allSelected: allSelected, someSelected: someSelected, onToggle: function (select) { return toggleSelectAll(select); } })));
                })); })),
                showSelectionColumn && (React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isSelectTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var selection = _a.selection;
                    var toggleSelection = _b.toggleSelection;
                    return (React.createElement(Cell, __assign({}, params, { row: params.tableRow.row, selected: selection.indexOf(params.tableRow.rowId) !== -1, onToggle: function () { return toggleSelection({ rowIds: [params.tableRow.rowId] }); } })));
                })); })),
                (highlightRow || selectByRowClick) && (React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isDataTableRow(tableRow);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var selection = _a.selection;
                    var toggleSelection = _b.toggleSelection;
                    return (React.createElement(Row, __assign({}, params, { selectByRowClick: selectByRowClick, highlighted: dxGridCore.isRowHighlighted(highlightRow, selection, params.tableRow), onToggle: function () { return toggleSelection({ rowIds: [params.tableRow.rowId] }); } })));
                })); }))));
        };
        TableSelectionBase.defaultProps = {
            highlightRow: false,
            selectByRowClick: false,
            showSelectAll: false,
            showSelectionColumn: true,
        };
        TableSelectionBase.components = {
            rowComponent: 'Row',
            cellComponent: 'Cell',
            headerCellComponent: 'HeaderCell',
        };
        TableSelectionBase.COLUMN_TYPE = dxGridCore.TABLE_SELECT_TYPE;
        return TableSelectionBase;
    }(React.PureComponent));
    /***
     * A plugin that visualizes table rows' selection state by rendering selection checkboxes
     * and highlighting the selected rows.
     * */
    var TableSelection = TableSelectionBase;

    // tslint:disable-next-line: max-line-length
    var RowDetailStateBase = /*#__PURE__*/ (function (_super) {
        __extends(RowDetailStateBase, _super);
        function RowDetailStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                expandedRowIds: props.expandedRowIds || props.defaultExpandedRowIds,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                expandedRowIds: function () {
                    var onExpandedRowIdsChange = _this.props.onExpandedRowIdsChange;
                    return onExpandedRowIdsChange;
                },
            });
            _this.toggleDetailRowExpanded = stateHelper.applyFieldReducer
                .bind(stateHelper, 'expandedRowIds', dxGridCore.toggleDetailRowExpanded);
            return _this;
        }
        RowDetailStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.expandedRowIds, expandedRowIds = _a === void 0 ? prevState.expandedRowIds : _a;
            return {
                expandedRowIds: expandedRowIds,
            };
        };
        RowDetailStateBase.prototype.render = function () {
            var expandedRowIds = this.state.expandedRowIds;
            return (React.createElement(dxReactCore.Plugin, { name: "RowDetailState" },
                React.createElement(dxReactCore.Getter, { name: "expandedDetailRowIds", value: expandedRowIds }),
                React.createElement(dxReactCore.Action, { name: "toggleDetailRowExpanded", action: this.toggleDetailRowExpanded })));
        };
        RowDetailStateBase.defaultProps = {
            defaultExpandedRowIds: [],
        };
        return RowDetailStateBase;
    }(React.PureComponent));
    /** A plugin that manages the expanded state for table row details. */
    var RowDetailState = RowDetailStateBase;

    var getCellColSpanComputed = function (_a) {
        var getTableCellColSpan = _a.getTableCellColSpan;
        return dxGridCore.tableDetailCellColSpanGetter(getTableCellColSpan);
    };
    var pluginDependencies$9 = [
        { name: 'RowDetailState' },
        { name: 'Table' },
    ];
    var TableRowDetailBase = /*#__PURE__*/ (function (_super) {
        __extends(TableRowDetailBase, _super);
        function TableRowDetailBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableRowDetailBase.prototype.render = function () {
            var _a = this.props, rowHeight = _a.rowHeight, Content = _a.contentComponent, ToggleCell = _a.toggleCellComponent, Cell = _a.cellComponent, Row = _a.rowComponent, toggleColumnWidth = _a.toggleColumnWidth;
            var tableColumnsComputed = function (_a) {
                var tableColumns = _a.tableColumns;
                return dxGridCore.tableColumnsWithDetail(tableColumns, toggleColumnWidth);
            };
            var tableBodyRowsComputed = function (_a) {
                var tableBodyRows = _a.tableBodyRows, expandedDetailRowIds = _a.expandedDetailRowIds;
                return dxGridCore.tableRowsWithExpandedDetail(tableBodyRows, expandedDetailRowIds, rowHeight);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "TableRowDetail", dependencies: pluginDependencies$9 },
                React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed }),
                React.createElement(dxReactCore.Getter, { name: "tableBodyRows", computed: tableBodyRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "getTableCellColSpan", computed: getCellColSpanComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isDetailToggleTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var expandedDetailRowIds = _a.expandedDetailRowIds;
                    var toggleDetailRowExpanded = _b.toggleDetailRowExpanded;
                    return (React.createElement(ToggleCell, __assign({}, params, { row: params.tableRow.row, expanded: dxGridCore.isDetailRowExpanded(expandedDetailRowIds, params.tableRow.rowId), onToggle: function () { return toggleDetailRowExpanded({ rowId: params.tableRow.rowId }); } })));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isDetailTableRow(tableRow);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var tableColumns = _a.tableColumns;
                    if (dxGridCore.isDetailTableCell(params.tableColumn, tableColumns)) {
                        return (React.createElement(Cell, __assign({}, params, { row: params.tableRow.row }), Content && React.createElement(Content, { row: params.tableRow.row })));
                    }
                    return null;
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isDetailTableRow(tableRow);
                    } }, function (params) { return (React.createElement(Row, __assign({}, params, { row: params.tableRow.row }))); })));
        };
        TableRowDetailBase.ROW_TYPE = dxGridCore.TABLE_DETAIL_TYPE;
        TableRowDetailBase.COLUMN_TYPE = dxGridCore.TABLE_DETAIL_TYPE;
        TableRowDetailBase.defaultProps = {
            contentComponent: function () { return null; },
        };
        TableRowDetailBase.components = {
            rowComponent: 'Row',
            cellComponent: 'Cell',
            toggleCellComponent: 'ToggleCell',
        };
        return TableRowDetailBase;
    }(React.PureComponent));
    /** A plugin that renders detail rows. */
    var TableRowDetail = TableRowDetailBase;

    var defaultSummaryMessages = {
        sum: 'Sum',
        min: 'Min',
        max: 'Max',
        avg: 'Avg',
        count: 'Count',
    };

    var TableSummaryContent = function (_a) {
        var column = _a.column, columnSummaries = _a.columnSummaries, formatlessSummaryTypes = _a.formatlessSummaryTypes, Item = _a.itemComponent, messages = _a.messages;
        var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultSummaryMessages), messages));
        var SummaryItem = function (_a) {
            var summary = _a.summary, children = _a.children;
            return (React.createElement(Item, { getMessage: getMessage, type: summary.type, value: summary.value }, children || String(summary.value)));
        };
        var isFormatlessSummary = function (summary) { return (summary.value === null
            || formatlessSummaryTypes.includes(summary.type)
            || dxGridCore.defaultFormatlessSummaries.includes(summary.type)); };
        return (React.createElement(React.Fragment, null, columnSummaries.map(function (summary) {
            if (isFormatlessSummary(summary)) {
                return React.createElement(SummaryItem, { key: summary.type, summary: summary });
            }
            return (React.createElement(dxReactCore.TemplatePlaceholder, { key: summary.type, name: "valueFormatter", params: {
                    column: column,
                    value: summary.value,
                } }, function (content) { return (React.createElement(SummaryItem, { summary: summary }, content)); }));
        })));
    };

    var getInlineSummaryComponent = function (column, summary, formatlessSummaries) { return function () { return ((summary.value === null || formatlessSummaries.includes(summary.type))
        ? React.createElement(React.Fragment, null, summary.value)
        : (React.createElement(dxReactCore.TemplatePlaceholder, { key: summary.type, name: "valueFormatter", params: {
                column: column,
                value: summary.value,
            } }, function (content) { return content || summary.value; }))); }; };
    var flattenGroupInlineSummaries = function (columns, tableRow, groupSummaryItems, groupSummaryValues, formatlessSummaries) { return (dxGridCore.getGroupInlineSummaries(groupSummaryItems, columns, groupSummaryValues[tableRow.row.compoundKey])
        .map(function (colSummaries) { return (__spreadArray([], __read(colSummaries.summaries.map(function (summary) { return (__assign(__assign({}, summary), { columnTitle: colSummaries.column.title, messageKey: "".concat(summary.type, "Of"), component: getInlineSummaryComponent(colSummaries.column, summary, formatlessSummaries) })); })), false)); })
        .reduce(function (acc, summaries) { return acc.concat(summaries); }, [])); };

    var pluginDependencies$a = [
        { name: 'GroupingState' },
        { name: 'Table' },
        { name: 'DataTypeProvider', optional: true },
        { name: 'SummaryState', optional: true },
        { name: 'CustomSummary', optional: true },
        { name: 'IntegratedSummary', optional: true },
        { name: 'Table' },
        { name: 'DataTypeProvider', optional: true },
        { name: 'TableSelection', optional: true },
    ];
    var side = 'left';
    /** @internal */
    var defaultMessages$1 = {
        countOf: 'Count: ',
        sumOf: 'Sum of {columnTitle} is ',
        maxOf: 'Max of {columnTitle} is ',
        minOf: 'Min of {columnTitle} is ',
        avgOf: 'Avg of {columnTitle} is ',
    };
    var tableBodyRowsComputed$1 = function (_a) {
        var tableBodyRows = _a.tableBodyRows, isGroupRow = _a.isGroupRow;
        return dxGridCore.tableRowsWithGrouping(tableBodyRows, isGroupRow);
    };
    var getCellColSpanComputed$1 = function (_a) {
        var getTableCellColSpan = _a.getTableCellColSpan, groupSummaryItems = _a.groupSummaryItems, viewport = _a.viewport;
        var firstVisibleColumnIndex = viewport === null || viewport === void 0 ? void 0 : viewport.columns[0][0];
        return dxGridCore.tableGroupCellColSpanGetter(getTableCellColSpan, groupSummaryItems, firstVisibleColumnIndex);
    };
    var TableGroupRowBase = /*#__PURE__*/ (function (_super) {
        __extends(TableGroupRowBase, _super);
        function TableGroupRowBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableGroupRowBase.prototype.render = function () {
            var _a = this.props, GroupCell = _a.cellComponent, Content = _a.contentComponent, Icon = _a.iconComponent, GroupRow = _a.rowComponent, Container = _a.containerComponent, GroupIndentCell = _a.indentCellComponent, InlineSummary = _a.inlineSummaryComponent, InlineSummaryItem = _a.inlineSummaryItemComponent, SummaryCell = _a.summaryCellComponent, SummaryItem = _a.summaryItemComponent, StubCell = _a.stubCellComponent, indentColumnWidth = _a.indentColumnWidth, contentCellPadding = _a.contentCellPadding, showColumnsWhenGrouped = _a.showColumnsWhenGrouped, columnExtensions = _a.columnExtensions, messages = _a.messages, formatlessSummaryTypes = _a.formatlessSummaryTypes;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$1), messages));
            return (React.createElement(dxReactCore.Plugin, { name: "TableGroupRow", dependencies: pluginDependencies$a },
                React.createElement(TableColumnsWithGrouping, { columnExtensions: columnExtensions, showColumnsWhenGrouped: showColumnsWhenGrouped, indentColumnWidth: indentColumnWidth }),
                React.createElement(dxReactCore.Getter, { name: "tableBodyRows", computed: tableBodyRowsComputed$1 }),
                React.createElement(dxReactCore.Getter, { name: "getTableCellColSpan", computed: getCellColSpanComputed$1 }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return dxGridCore.isGroupTableRow(tableRow);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var grouping = _a.grouping, expandedGroups = _a.expandedGroups, groupSummaryItems = _a.groupSummaryItems, groupSummaryValues = _a.groupSummaryValues, columns = _a.columns;
                    var toggleGroupExpanded = _b.toggleGroupExpanded;
                    if (dxGridCore.isGroupTableCell(params.tableRow, params.tableColumn)) {
                        var formatlessSummaries = dxGridCore.defaultFormatlessSummaries
                            .concat(formatlessSummaryTypes);
                        var inlineSummaries_1 = groupSummaryItems
                            ? flattenGroupInlineSummaries(columns, params.tableRow, groupSummaryItems, groupSummaryValues, formatlessSummaries) : [];
                        var cellIndent = dxGridCore.calculateGroupCellIndent(params.tableColumn, grouping, indentColumnWidth);
                        var contentIndent_1 = "calc(".concat(cellIndent, "px + ").concat(contentCellPadding, ")");
                        return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "valueFormatter", params: {
                                column: params.tableColumn.column,
                                value: params.tableRow.row.value,
                            } }, function (content) { return (React.createElement(GroupCell, __assign({}, params, { contentComponent: Content, iconComponent: Icon, containerComponent: Container, row: params.tableRow.row, column: params.tableColumn.column, expanded: expandedGroups.indexOf(params.tableRow.row.compoundKey) !== -1, onToggle: function () { return toggleGroupExpanded({ groupKey: params.tableRow.row.compoundKey }); }, inlineSummaries: inlineSummaries_1, inlineSummaryComponent: InlineSummary, inlineSummaryItemComponent: InlineSummaryItem, getMessage: getMessage, position: contentIndent_1, side: side }), content)); }));
                    }
                    if (dxGridCore.isGroupIndentTableCell(params.tableRow, params.tableColumn, grouping)) {
                        var fixedProps = {
                            side: side,
                            position: dxGridCore.calculateGroupCellIndent(params.tableColumn, grouping, indentColumnWidth),
                        };
                        if (GroupIndentCell) {
                            return (React.createElement(GroupIndentCell, __assign({}, params, fixedProps, { row: params.tableRow.row, column: params.tableColumn.column })));
                        }
                        return React.createElement(dxReactCore.TemplatePlaceholder, { params: fixedProps });
                    }
                    if (dxGridCore.isGroupIndentStubTableCell(params.tableRow, params.tableColumn, grouping)) {
                        return React.createElement(dxReactCore.TemplatePlaceholder, { params: params });
                    }
                    return null;
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return (dxGridCore.isGroupRowOrdinaryCell(tableRow, tableColumn));
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var groupSummaryItems = _a.groupSummaryItems, groupSummaryValues = _a.groupSummaryValues, grouping = _a.grouping, tableColumns = _a.tableColumns;
                    var toggleGroupExpanded = _b.toggleGroupExpanded;
                    var tableColumn = params.tableColumn, tableRow = params.tableRow;
                    var onToggle = function () { return toggleGroupExpanded({ groupKey: tableRow.row.compoundKey }); };
                    if (dxGridCore.isRowSummaryCell(tableRow, tableColumn, grouping, groupSummaryItems)) {
                        var columnSummaries = dxGridCore.getColumnSummaries(groupSummaryItems, tableColumn.column.name, groupSummaryValues[tableRow.row.compoundKey], function (summaryItem) { return (!summaryItem.showInGroupFooter &&
                            summaryItem.alignByColumn); });
                        return (React.createElement(SummaryCell, __assign({}, params, { row: params.tableRow.row, column: params.tableColumn.column, onToggle: onToggle }),
                            React.createElement(TableSummaryContent, { column: tableColumn.column, columnSummaries: columnSummaries, formatlessSummaryTypes: formatlessSummaryTypes, itemComponent: SummaryItem, messages: messages })));
                    }
                    // NOTE: ensure that right-aligned summary will fit into a column
                    if (dxGridCore.isPreviousCellContainSummary(tableRow, tableColumn, tableColumns, grouping, groupSummaryItems) || dxGridCore.TABLE_FLEX_TYPE === tableColumn.type) {
                        return React.createElement(StubCell, __assign({}, params, { onToggle: onToggle }));
                    }
                    return React.createElement(dxReactCore.TemplatePlaceholder, null);
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return dxGridCore.isGroupTableRow(tableRow);
                    } }, function (params) { return (React.createElement(GroupRow, __assign({}, params, { row: params.tableRow.row }))); })));
        };
        TableGroupRowBase.ROW_TYPE = dxGridCore.TABLE_GROUP_TYPE;
        TableGroupRowBase.COLUMN_TYPE = dxGridCore.TABLE_GROUP_TYPE;
        TableGroupRowBase.defaultProps = {
            showColumnsWhenGrouped: false,
            formatlessSummaryTypes: [],
        };
        TableGroupRowBase.components = {
            rowComponent: 'Row',
            cellComponent: 'Cell',
            contentComponent: 'Content',
            iconComponent: 'Icon',
            containerComponent: 'Container',
            indentCellComponent: 'IndentCell',
            inlineSummaryComponent: 'InlineSummary',
            inlineSummaryItemComponent: 'InlineSummaryItem',
            summaryCellComponent: 'SummaryCell',
            summaryItemComponent: 'SummaryItem',
            stubCellComponent: 'StubCell',
        };
        return TableGroupRowBase;
    }(React.PureComponent));
    /** A plugin that renders group rows and enables them to expand and collapse. */
    var TableGroupRow = TableGroupRowBase;

    var tableHeaderRowsComputed$1 = function (_a) {
        var tableHeaderRows = _a.tableHeaderRows;
        return dxGridCore.tableRowsWithHeading(tableHeaderRows || []);
    };
    var TableHeaderRowBase = /*#__PURE__*/ (function (_super) {
        __extends(TableHeaderRowBase, _super);
        function TableHeaderRowBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableHeaderRowBase.prototype.render = function () {
            var _a = this.props, showSortingControls = _a.showSortingControls, showGroupingControls = _a.showGroupingControls, HeaderCell = _a.cellComponent, HeaderRow = _a.rowComponent, Content = _a.contentComponent, SortLabel = _a.sortLabelComponent, GroupButton = _a.groupButtonComponent, Title = _a.titleComponent, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(messages);
            return (React.createElement(dxReactCore.Plugin, { name: "TableHeaderRow", dependencies: [
                    { name: 'Table' },
                    { name: 'SortingState', optional: !showSortingControls },
                    { name: 'GroupingState', optional: !showGroupingControls },
                    { name: 'DragDropProvider', optional: true },
                    { name: 'TableColumnResizing', optional: true },
                ] },
                React.createElement(dxReactCore.Getter, { name: "tableHeaderRows", computed: tableHeaderRowsComputed$1 }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isHeadingTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var sorting = _a.sorting, tableColumns = _a.tableColumns, draggingEnabled = _a.draggingEnabled, tableColumnResizingEnabled = _a.tableColumnResizingEnabled, isColumnSortingEnabled = _a.isColumnSortingEnabled, isColumnGroupingEnabled = _a.isColumnGroupingEnabled, columnResizingMode = _a.columnResizingMode;
                    var changeColumnSorting = _b.changeColumnSorting, changeColumnGrouping = _b.changeColumnGrouping, changeTableColumnWidth = _b.changeTableColumnWidth, draftTableColumnWidth = _b.draftTableColumnWidth, cancelTableColumnWidthDraft = _b.cancelTableColumnWidthDraft, _c = _b.storeWidthGetters, storeWidthGetters = _c === void 0 ? function () { } : _c;
                    var _d = params.tableColumn.column, columnName = _d.name, columnTitle = _d.title;
                    var atLeastOneDataColumn = tableColumns
                        .filter(function (_a) {
                        var type = _a.type;
                        return type === dxGridCore.TABLE_DATA_TYPE;
                    }).length > 1;
                    var sortingEnabled = isColumnSortingEnabled
                        && isColumnSortingEnabled(columnName);
                    var groupingEnabled = isColumnGroupingEnabled
                        && isColumnGroupingEnabled(columnName)
                        && atLeastOneDataColumn;
                    var nextColumnName = dxGridCore.getNextColumnName(tableColumns, columnName);
                    return (React.createElement(HeaderCell, __assign({}, params, { column: params.tableColumn.column, draggingEnabled: draggingEnabled && atLeastOneDataColumn, resizingEnabled: tableColumnResizingEnabled
                            && (!!nextColumnName || columnResizingMode === 'widget'), onWidthChange: function (_a) {
                            var shift = _a.shift;
                            return changeTableColumnWidth({
                                columnName: columnName,
                                nextColumnName: nextColumnName,
                                shift: shift,
                            });
                        }, onWidthDraft: function (_a) {
                            var shift = _a.shift;
                            return draftTableColumnWidth({
                                columnName: columnName,
                                nextColumnName: nextColumnName,
                                shift: shift,
                            });
                        }, onWidthDraftCancel: function () { return cancelTableColumnWidthDraft(); }, getCellWidth: function (getter) { return storeWidthGetters({
                            tableColumn: params.tableColumn,
                            getter: getter,
                            tableColumns: tableColumns,
                        }); } }),
                        React.createElement(dxReactCore.TemplatePlaceholder, { name: "tableHeaderCellBefore", params: {
                                column: params.tableColumn.column,
                            } }),
                        React.createElement(Content, { column: params.tableColumn.column, align: params.tableColumn.align }, showSortingControls ? (React.createElement(SortLabel, { column: params.tableColumn.column, align: params.tableColumn.align, direction: dxGridCore.getColumnSortingDirection(sorting, columnName) || null, disabled: !sortingEnabled, onSort: function (_a) {
                                var direction = _a.direction, keepOther = _a.keepOther;
                                changeColumnSorting({ columnName: columnName, direction: direction, keepOther: keepOther });
                            }, getMessage: getMessage },
                            React.createElement(Title, null, columnTitle || columnName))) : (React.createElement(Title, null, columnTitle || columnName))),
                        showGroupingControls ? (React.createElement(GroupButton, { disabled: !groupingEnabled, onGroup: function () { return changeColumnGrouping({ columnName: columnName }); } })) : null));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isHeadingTableRow(tableRow);
                    } }, function (params) { return React.createElement(HeaderRow, __assign({}, params)); })));
        };
        TableHeaderRowBase.ROW_TYPE = dxGridCore.TABLE_HEADING_TYPE;
        TableHeaderRowBase.defaultProps = {
            showSortingControls: false,
            showGroupingControls: false,
            messages: {},
        };
        TableHeaderRowBase.components = {
            cellComponent: 'Cell',
            rowComponent: 'Row',
            contentComponent: 'Content',
            sortLabelComponent: 'SortLabel',
            titleComponent: 'Title',
            groupButtonComponent: 'GroupButton',
        };
        return TableHeaderRowBase;
    }(React.PureComponent));
    TableHeaderRowBase.components = {
        cellComponent: 'Cell',
        rowComponent: 'Row',
        contentComponent: 'Content',
        sortLabelComponent: 'SortLabel',
        titleComponent: 'Title',
        groupButtonComponent: 'GroupButton',
    };
    /***
     * A plugin that renders the table's header row. The Column's `title` field specifies the
     * column's title in the header row.The plugin also allows you to manage a column's sorting
     * and grouping state and initiate column dragging.
     * */
    var TableHeaderRow = TableHeaderRowBase;

    var CellPlaceholder$1 = function (props) { return React.createElement(dxReactCore.TemplatePlaceholder, { params: props }); };
    var bandLevelsVisibilityComputed = function (_a) {
        var columnIntervals = _a.columnVisibleIntervals, tableHeaderColumnChains = _a.tableHeaderColumnChains, bandLevels = _a.bandLevels;
        return dxGridCore.bandLevelsVisibility(columnIntervals, tableHeaderColumnChains, bandLevels);
    };
    var columnVisibleIntervalsComputed = function (_a) {
        var viewport = _a.viewport, tableColumns = _a.tableColumns;
        return dxGridCore.columnVisibleIntervals(viewport, tableColumns);
    };
    var TableBandHeaderBase = /*#__PURE__*/ (function (_super) {
        __extends(TableBandHeaderBase, _super);
        function TableBandHeaderBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableBandHeaderBase.prototype.render = function () {
            var _a = this.props, Cell = _a.cellComponent, Row = _a.rowComponent, HeaderCell = _a.bandedHeaderCellComponent, InvisibleCell = _a.invisibleCellComponent, columnBands = _a.columnBands;
            var tableHeaderRowsComputed = function (_a) {
                var tableHeaderRows = _a.tableHeaderRows, tableColumns = _a.tableColumns;
                return dxGridCore.tableRowsWithBands(tableHeaderRows, columnBands, tableColumns);
            };
            var tableHeaderColumnChainsComputed = function (_a) {
                var tableHeaderRows = _a.tableHeaderRows, tableColumns = _a.tableColumns;
                return dxGridCore.tableHeaderColumnChainsWithBands(tableHeaderRows, tableColumns, columnBands);
            };
            var bandLevels = dxGridCore.columnBandLevels(columnBands);
            return (React.createElement(dxReactCore.Plugin, { name: "TableBandHeader", dependencies: [
                    { name: 'Table' },
                    { name: 'TableHeaderRow' },
                    { name: 'TableSelection', optional: true },
                    { name: 'TableEditColumn', optional: true },
                    { name: 'TableColumnVisibility', optional: true },
                    { name: 'TableGroupRow', optional: true },
                ] },
                React.createElement(dxReactCore.Getter, { name: "tableHeaderRows", computed: tableHeaderRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "columnVisibleIntervals", computed: columnVisibleIntervalsComputed }),
                React.createElement(dxReactCore.Getter, { name: "tableHeaderColumnChains", computed: tableHeaderColumnChainsComputed }),
                React.createElement(dxReactCore.Getter, { name: "bandLevels", value: bandLevels }),
                React.createElement(dxReactCore.Getter, { name: "bandLevelsVisibility", computed: bandLevelsVisibilityComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return dxGridCore.isBandedOrHeaderRow(tableRow);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var tableColumns = _a.tableColumns, tableHeaderRows = _a.tableHeaderRows, tableHeaderColumnChains = _a.tableHeaderColumnChains, columnIntervals = _a.columnVisibleIntervals, levelsVisibility = _a.bandLevelsVisibility;
                    var bandComponent = dxGridCore.getBandComponent(params, tableHeaderRows, tableColumns, columnBands, tableHeaderColumnChains, columnIntervals, levelsVisibility);
                    switch (bandComponent.type) {
                        case dxGridCore.BAND_DUPLICATE_RENDER:
                            return React.createElement(dxReactCore.TemplatePlaceholder, { params: __assign({}, params) });
                        case dxGridCore.BAND_EMPTY_CELL:
                            return React.createElement(InvisibleCell, null);
                        case dxGridCore.BAND_GROUP_CELL: {
                            var _b = bandComponent.payload, value = _b.value, payload = __rest(_b, ["value"]);
                            return (React.createElement(Cell, __assign({}, params, payload), value));
                        }
                        case dxGridCore.BAND_HEADER_CELL:
                            return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "tableCell", params: __assign(__assign({}, params), bandComponent.payload) }));
                        case dxGridCore.BAND_FILL_LEVEL_CELL:
                            return (React.createElement(Cell, __assign({}, params, bandComponent.payload, { style: { whiteSpace: 'pre' } }), ' '));
                        default:
                            return null;
                    }
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isHeadingTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(HeaderCell, __assign({ component: CellPlaceholder$1 }, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return dxGridCore.isBandedTableRow(tableRow);
                    } }, function (params) { return React.createElement(Row, __assign({}, params)); })));
        };
        TableBandHeaderBase.ROW_TYPE = dxGridCore.TABLE_BAND_TYPE;
        TableBandHeaderBase.components = {
            cellComponent: 'Cell',
            rowComponent: 'Row',
            bandedHeaderCellComponent: 'BandedHeaderCell',
            invisibleCellComponent: 'InvisibleCell',
        };
        return TableBandHeaderBase;
    }(React.PureComponent));
    TableBandHeaderBase.components = {
        cellComponent: 'Cell',
        rowComponent: 'Row',
        bandedHeaderCellComponent: 'BandedHeaderCell',
        invisibleCellComponent: 'InvisibleCell',
    };
    /** A plugin that renders the banded cells. */
    var TableBandHeader = TableBandHeaderBase;

    var pluginDependencies$b = [
        { name: 'FilteringState' },
        { name: 'Table' },
        { name: 'DataTypeProvider', optional: true },
    ];
    var defaultMessages$2 = {
        filterPlaceholder: 'Filter...',
        contains: 'Contains',
        notContains: 'Does not contain',
        startsWith: 'Starts with',
        endsWith: 'Ends with',
        equal: 'Equals',
        notEqual: 'Does not equal',
        greaterThan: 'Greater than',
        greaterThanOrEqual: 'Greater than or equal to',
        lessThan: 'Less than',
        lessThanOrEqual: 'Less than or equal to',
    };
    var TableFilterRowBase = /*#__PURE__*/ (function (_super) {
        __extends(TableFilterRowBase, _super);
        function TableFilterRowBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                filterOperations: {},
            };
            return _this;
        }
        TableFilterRowBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, rowHeight = _a.rowHeight, showFilterSelector = _a.showFilterSelector, FilterCell = _a.cellComponent, FilterRow = _a.rowComponent, FilterSelector = _a.filterSelectorComponent, iconComponent = _a.iconComponent, toggleButtonComponent = _a.toggleButtonComponent, EditorComponent = _a.editorComponent, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$2), messages));
            var tableHeaderRowsComputed = function (_a) {
                var tableHeaderRows = _a.tableHeaderRows;
                return dxGridCore.tableHeaderRowsWithFilter(tableHeaderRows, rowHeight);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "TableFilterRow", dependencies: pluginDependencies$b },
                React.createElement(dxReactCore.Getter, { name: "tableHeaderRows", computed: tableHeaderRowsComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isFilterTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var filters = _a.filters, isColumnFilteringEnabled = _a.isColumnFilteringEnabled, getAvailableFilterOperations = _a.getAvailableFilterOperations, isDataRemote = _a.isDataRemote;
                    var changeColumnFilter = _b.changeColumnFilter, scrollToRow = _b.scrollToRow;
                    var filterOperations = _this.state.filterOperations;
                    var columnName = params.tableColumn.column.name;
                    var filter = dxGridCore.getColumnFilterConfig(filters, columnName);
                    var onFilter = function (config) {
                        if (isDataRemote) {
                            scrollToRow(dxGridCore.TOP_POSITION);
                        }
                        changeColumnFilter({ columnName: columnName, config: config });
                    };
                    var columnFilterOperations = dxGridCore.getColumnFilterOperations(getAvailableFilterOperations, columnName);
                    var selectedFilterOperation = dxGridCore.getSelectedFilterOperation(filterOperations, columnName, filter, columnFilterOperations);
                    var handleFilterOperationChange = function (value) {
                        var _a;
                        _this.setState({
                            filterOperations: __assign(__assign({}, filterOperations), (_a = {}, _a[columnName] = value, _a)),
                        });
                        if (filter && !dxGridCore.isFilterValueEmpty(filter.value)) {
                            onFilter({ value: filter.value, operation: value });
                        }
                    };
                    var handleFilterValueChange = function (value) { return onFilter(!dxGridCore.isFilterValueEmpty(value)
                        ? { value: value, operation: selectedFilterOperation }
                        : null); };
                    var filteringEnabled = isColumnFilteringEnabled(columnName);
                    return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "valueEditor", params: {
                            column: params.tableColumn.column,
                            value: filter ? filter.value : undefined,
                            onValueChange: handleFilterValueChange,
                            disabled: !filteringEnabled,
                        } }, function (content) { return (React.createElement(FilterCell, __assign({}, params, { getMessage: getMessage, column: params.tableColumn.column, filter: filter, filteringEnabled: filteringEnabled, onFilter: onFilter }),
                        showFilterSelector
                            ? (React.createElement(FilterSelector, { toggleButtonComponent: toggleButtonComponent, iconComponent: iconComponent, value: selectedFilterOperation, availableValues: columnFilterOperations, onChange: handleFilterOperationChange, disabled: !filteringEnabled, getMessage: getMessage })) : null,
                        content || (React.createElement(EditorComponent, { value: filter ? filter.value : undefined, disabled: !filteringEnabled, getMessage: getMessage, onChange: handleFilterValueChange })))); }));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isFilterTableRow(tableRow);
                    } }, function (params) { return React.createElement(FilterRow, __assign({}, params)); })));
        };
        TableFilterRowBase.ROW_TYPE = dxGridCore.TABLE_FILTER_TYPE;
        TableFilterRowBase.defaultProps = {
            showFilterSelector: false,
            messages: {},
        };
        TableFilterRowBase.components = {
            rowComponent: 'Row',
            cellComponent: 'Cell',
            filterSelectorComponent: 'FilterSelector',
            iconComponent: 'Icon',
            editorComponent: 'Editor',
            toggleButtonComponent: 'ToggleButton',
        };
        return TableFilterRowBase;
    }(React.PureComponent));
    /** A plugin that renders a filter row. */
    var TableFilterRow = TableFilterRowBase;

    var pluginDependencies$c = [
        { name: 'EditingState' },
        { name: 'Table' },
        { name: 'DataTypeProvider', optional: true },
    ];
    var TableEditRowBase = /*#__PURE__*/ (function (_super) {
        __extends(TableEditRowBase, _super);
        function TableEditRowBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableEditRowBase.prototype.render = function () {
            var _a = this.props, EditCell = _a.cellComponent, EditRow = _a.rowComponent, rowHeight = _a.rowHeight;
            var tableBodyRowsComputed = function (_a) {
                var tableBodyRows = _a.tableBodyRows, editingRowIds = _a.editingRowIds, addedRows = _a.addedRows;
                return dxGridCore.tableRowsWithEditing(tableBodyRows, editingRowIds, addedRows, rowHeight);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "TableEditRow", dependencies: pluginDependencies$c },
                React.createElement(dxReactCore.Getter, { name: "tableBodyRows", computed: tableBodyRowsComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isEditTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var getCellValue = _a.getCellValue, createRowChange = _a.createRowChange, rowChanges = _a.rowChanges, isColumnEditingEnabled = _a.isColumnEditingEnabled;
                    var changeAddedRow = _b.changeAddedRow, changeRow = _b.changeRow;
                    var _c = params.tableRow, rowId = _c.rowId, row = _c.row;
                    var column = params.tableColumn.column;
                    var columnName = column.name;
                    var isNew = dxGridCore.isAddedTableRow(params.tableRow);
                    var changedRow = isNew
                        ? row
                        : __assign(__assign({}, row), dxGridCore.getRowChange(rowChanges, rowId));
                    var value = getCellValue(changedRow, columnName);
                    var onValueChange = function (newValue) {
                        var changeArgs = {
                            rowId: rowId,
                            change: createRowChange(changedRow, newValue, columnName),
                        };
                        if (isNew) {
                            changeAddedRow(changeArgs);
                        }
                        else {
                            changeRow(changeArgs);
                        }
                    };
                    var editingEnabled = isColumnEditingEnabled(columnName);
                    return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "valueEditor", params: {
                            column: column,
                            row: row,
                            value: value,
                            onValueChange: onValueChange,
                            disabled: !editingEnabled,
                        } }, function (content) { return (React.createElement(EditCell, __assign({}, params, { row: row, column: column, value: value, editingEnabled: editingEnabled, onValueChange: onValueChange }), content)); }));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!(dxGridCore.isEditTableRow(tableRow) || dxGridCore.isAddedTableRow(tableRow));
                    } }, function (params) { return (React.createElement(EditRow, __assign({}, params, { row: params.tableRow.row }))); })));
        };
        TableEditRowBase.ADDED_ROW_TYPE = dxGridCore.TABLE_ADDED_TYPE;
        TableEditRowBase.EDIT_ROW_TYPE = dxGridCore.TABLE_EDIT_TYPE;
        TableEditRowBase.components = {
            rowComponent: 'Row',
            cellComponent: 'Cell',
        };
        return TableEditRowBase;
    }(React.PureComponent));
    /** A plugin that renders a row being edited. */
    var TableEditRow = TableEditRowBase;

    var pluginDependencies$d = [
        { name: 'EditingState' },
        { name: 'Table' },
    ];
    var defaultMessages$3 = {
        addCommand: 'New',
        editCommand: 'Edit',
        deleteCommand: 'Delete',
        commitCommand: 'Save',
        cancelCommand: 'Cancel',
    };
    var TableEditColumnBase = /*#__PURE__*/ (function (_super) {
        __extends(TableEditColumnBase, _super);
        function TableEditColumnBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableEditColumnBase.prototype.render = function () {
            var _a = this.props, Cell = _a.cellComponent, HeaderCell = _a.headerCellComponent, Command = _a.commandComponent, showAddCommand = _a.showAddCommand, showEditCommand = _a.showEditCommand, showDeleteCommand = _a.showDeleteCommand, width = _a.width, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$3), messages));
            var tableColumnsComputed = function (_a) {
                var tableColumns = _a.tableColumns;
                return dxGridCore.tableColumnsWithEditing(tableColumns, width);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "TableEditColumn", dependencies: pluginDependencies$d },
                React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isHeadingEditCommandsTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (getters, actions) { return (React.createElement(HeaderCell, __assign({}, params), showAddCommand && (React.createElement(Command, { id: "add", text: getMessage('addCommand'), onExecute: function () { return actions.addRow(); } })))); })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isEditCommandsTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (getters, actions) {
                    var isEdit = dxGridCore.isEditTableRow(params.tableRow);
                    var isNew = dxGridCore.isAddedTableRow(params.tableRow);
                    var isEditing = isEdit || isNew;
                    var rowIds = [params.tableRow.rowId];
                    return (React.createElement(Cell, __assign({}, params, { row: params.tableRow.row }),
                        showEditCommand && !isEditing && (React.createElement(Command, { id: "edit", text: getMessage('editCommand'), onExecute: function () { return actions.startEditRows({ rowIds: rowIds }); } })),
                        showDeleteCommand && !isEditing && (React.createElement(Command, { id: "delete", text: getMessage('deleteCommand'), onExecute: function () {
                                actions.deleteRows({ rowIds: rowIds });
                                actions.commitDeletedRows({ rowIds: rowIds });
                            } })),
                        isEditing && (React.createElement(Command, { id: "commit", text: getMessage('commitCommand'), onExecute: function () {
                                if (isNew) {
                                    actions.commitAddedRows({ rowIds: rowIds });
                                }
                                else {
                                    actions.stopEditRows({ rowIds: rowIds });
                                    actions.commitChangedRows({ rowIds: rowIds });
                                }
                            } })),
                        isEditing && (React.createElement(Command, { id: "cancel", text: getMessage('cancelCommand'), onExecute: function () {
                                if (isNew) {
                                    actions.cancelAddedRows({ rowIds: rowIds });
                                }
                                else {
                                    actions.stopEditRows({ rowIds: rowIds });
                                    actions.cancelChangedRows({ rowIds: rowIds });
                                }
                            } }))));
                })); })));
        };
        TableEditColumnBase.COLUMN_TYPE = dxGridCore.TABLE_EDIT_COMMAND_TYPE;
        TableEditColumnBase.defaultProps = {
            showAddCommand: false,
            showEditCommand: false,
            showDeleteCommand: false,
            width: 140,
            messages: {},
        };
        TableEditColumnBase.components = {
            cellComponent: 'Cell',
            headerCellComponent: 'HeaderCell',
            commandComponent: 'Command',
        };
        return TableEditColumnBase;
    }(React.PureComponent));
    /***
     * A plugin that renders a command column. This column contains controls used for row editing,
     * creating, or deleting and committing/canceling changes.
     * */
    var TableEditColumn = TableEditColumnBase;

    var pluginDependencies$e = [
        { name: 'Table' },
    ];
    // tslint:disable-next-line: max-line-length
    var TableColumnResizingBase = /*#__PURE__*/ (function (_super) {
        __extends(TableColumnResizingBase, _super);
        function TableColumnResizingBase(props) {
            var _this = _super.call(this, props) || this;
            _this.widthGetters = {};
            _this.cachedWidths = {};
            _this.state = {
                columnWidths: props.columnWidths || props.defaultColumnWidths,
                draftColumnWidths: [],
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                columnWidths: function () {
                    var onColumnWidthsChange = _this.props.onColumnWidthsChange;
                    return onColumnWidthsChange;
                },
            });
            _this.tableColumnsComputed = dxCore.memoize(function (columnWidths) { return function (_a) {
                var tableColumns = _a.tableColumns;
                return dxGridCore.tableColumnsWithWidths(tableColumns, columnWidths, _this.props.resizingMode);
            }; });
            _this.tableColumnsDraftComputed = dxCore.memoize(function (draftColumnWidths) { return function (_a) {
                var tableColumns = _a.tableColumns;
                return dxGridCore.tableColumnsWithDraftWidths(tableColumns, draftColumnWidths, _this.props.resizingMode);
            }; });
            _this.changeTableColumnWidth = stateHelper.applyReducer.bind(stateHelper, function (prevState, payload) {
                var cachedWidths = __assign({}, _this.cachedWidths);
                var _a = _this.props, minColumnWidth = _a.minColumnWidth, maxColumnWidth = _a.maxColumnWidth, columnExtensions = _a.columnExtensions, resizingMode = _a.resizingMode;
                return dxGridCore.changeTableColumnWidth(prevState, __assign(__assign({}, payload), { cachedWidths: cachedWidths, resizingMode: resizingMode, minColumnWidth: minColumnWidth, maxColumnWidth: maxColumnWidth, columnExtensions: columnExtensions }));
            });
            _this.draftTableColumnWidth = stateHelper.applyReducer.bind(stateHelper, function (prevState, payload) {
                _this.storeCache(payload);
                var cachedWidths = _this.cachedWidths;
                var _a = _this.props, minColumnWidth = _a.minColumnWidth, maxColumnWidth = _a.maxColumnWidth, columnExtensions = _a.columnExtensions, resizingMode = _a.resizingMode;
                return dxGridCore.draftTableColumnWidth(prevState, __assign(__assign({}, payload), { cachedWidths: cachedWidths, resizingMode: resizingMode, minColumnWidth: minColumnWidth, maxColumnWidth: maxColumnWidth, columnExtensions: columnExtensions }));
            });
            _this.cancelTableColumnWidthDraft = stateHelper.applyReducer.bind(stateHelper, dxGridCore.cancelTableColumnWidthDraft);
            _this.storeCache = function (_a) {
                var columnName = _a.columnName, nextColumnName = _a.nextColumnName;
                if (Object.keys(_this.cachedWidths).length === 0) {
                    _this.cachedWidths[columnName] = _this.widthGetters[columnName]();
                    if (nextColumnName) {
                        _this.cachedWidths[nextColumnName] = _this.widthGetters[nextColumnName]();
                    }
                }
            };
            _this.clearCache = function () {
                Object.keys(_this.cachedWidths)
                    .forEach(function (columnName) { return delete _this.cachedWidths[columnName]; });
            };
            _this.storeWidthGetters = dxCore.memoize(function (_a) {
                var tableColumn = _a.tableColumn, getter = _a.getter, tableColumns = _a.tableColumns;
                if (tableColumn.type === dxGridCore.TABLE_DATA_TYPE) {
                    _this.widthGetters[tableColumn.column.name] = getter;
                }
                Object.keys(_this.widthGetters)
                    .forEach(function (columnName) {
                    var columnIndex = tableColumns
                        .findIndex(function (_a) {
                        var type = _a.type, column = _a.column;
                        return type === dxGridCore.TABLE_DATA_TYPE && column.name === columnName;
                    });
                    if (columnIndex === -1) {
                        delete _this.widthGetters[columnName];
                    }
                });
            });
            return _this;
        }
        TableColumnResizingBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.columnWidths, columnWidths = _a === void 0 ? prevState.columnWidths : _a;
            return {
                columnWidths: columnWidths,
            };
        };
        TableColumnResizingBase.prototype.componentDidUpdate = function (_, prevState) {
            var currentWidths = this.state.columnWidths;
            var prevWidths = prevState.columnWidths;
            if (currentWidths !== prevWidths) {
                this.clearCache();
            }
        };
        TableColumnResizingBase.prototype.render = function () {
            var _a = this.state, columnWidths = _a.columnWidths, draftColumnWidths = _a.draftColumnWidths;
            var resizingMode = this.props.resizingMode;
            var tableColumnsComputed = this.tableColumnsComputed(columnWidths);
            var tableColumnsDraftComputed = this.tableColumnsDraftComputed(draftColumnWidths);
            return (React.createElement(dxReactCore.Plugin, { name: "TableColumnResizing", dependencies: pluginDependencies$e },
                React.createElement(dxReactCore.Getter, { name: "tableColumnResizingEnabled", value: true }),
                React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed }),
                React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsDraftComputed }),
                React.createElement(dxReactCore.Getter, { name: "columnResizingMode", value: resizingMode }),
                React.createElement(dxReactCore.Action, { name: "changeTableColumnWidth", action: this.changeTableColumnWidth }),
                React.createElement(dxReactCore.Action, { name: "draftTableColumnWidth", action: this.draftTableColumnWidth }),
                React.createElement(dxReactCore.Action, { name: "cancelTableColumnWidthDraft", action: this.cancelTableColumnWidthDraft }),
                React.createElement(dxReactCore.Action, { name: "storeWidthGetters", action: this.storeWidthGetters })));
        };
        TableColumnResizingBase.defaultProps = {
            defaultColumnWidths: [],
            resizingMode: 'widget',
        };
        return TableColumnResizingBase;
    }(React.PureComponent));
    /* tslint:disable: max-line-length */
    /** A plugin that manages table column widths. */
    var TableColumnResizing = TableColumnResizingBase;
    /* tslint:enable: max-line-length */

    var pluginDependencies$f = [
        { name: 'PagingState' },
    ];
    var defaultMessages$4 = {
        showAll: 'All',
        info: function (_a) {
            var from = _a.from, to = _a.to, count = _a.count;
            return "".concat(from).concat(from < to ? "-".concat(to) : '', " of ").concat(count);
        },
    };
    var PagingPanelBase = /*#__PURE__*/ (function (_super) {
        __extends(PagingPanelBase, _super);
        function PagingPanelBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        PagingPanelBase.prototype.render = function () {
            var _a = this.props, Pager = _a.containerComponent, pageSizes = _a.pageSizes, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$4), messages));
            return (React.createElement(dxReactCore.Plugin, { name: "PagingPanel", dependencies: pluginDependencies$f },
                React.createElement(dxReactCore.Template, { name: "footer" }, function (params) { return (React.createElement(React.Fragment, null,
                    React.createElement(dxReactCore.TemplatePlaceholder, null),
                    React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                        var currentPage = _a.currentPage, pageSize = _a.pageSize, totalCount = _a.totalCount;
                        var setCurrentPage = _b.setCurrentPage, setPageSize = _b.setPageSize;
                        return (React.createElement(Pager, __assign({}, params, { currentPage: currentPage, pageSize: pageSize, totalCount: totalCount, totalPages: dxGridCore.pageCount(totalCount, pageSize), pageSizes: pageSizes, getMessage: getMessage, onCurrentPageChange: setCurrentPage, onPageSizeChange: setPageSize })));
                    }))); })));
        };
        PagingPanelBase.defaultProps = {
            pageSizes: [],
            messages: {},
        };
        PagingPanelBase.components = {
            containerComponent: 'Container',
        };
        return PagingPanelBase;
    }(React.PureComponent));
    /** A plugin that renders the paging panel used for navigation through data pages. */
    var PagingPanel = PagingPanelBase;

    var defaultProps = {
        draggingEnabled: false,
        onDragStart: function () { },
        onDragEnd: function () { },
    };
    // tslint:disable-next-line: max-line-length
    var ItemLayout = /*#__PURE__*/ (function (_super) {
        __extends(ItemLayout, _super);
        function ItemLayout(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                dragging: false,
            };
            return _this;
        }
        ItemLayout.prototype.render = function () {
            var _this = this;
            var _a = this.props, item = _a.item, Item = _a.itemComponent, itemRef = _a.itemRef, draggingEnabled = _a.draggingEnabled, onDragStart = _a.onDragStart, onDragEnd = _a.onDragEnd;
            var dragging = this.state.dragging;
            var itemElement = React.createElement(Item, { item: __assign(__assign({}, item), { draft: dragging || item.draft }) });
            return (draggingEnabled ? (React.createElement(dxReactCore.DragSource, { payload: [{ type: 'column', columnName: item.column.name }], onStart: function () {
                    _this.setState({ dragging: true });
                    onDragStart();
                }, onEnd: function () {
                    _this.setState({ dragging: false });
                    onDragEnd();
                }, ref: itemRef }, itemElement)) : (itemElement));
        };
        ItemLayout.defaultProps = defaultProps;
        return ItemLayout;
    }(React.PureComponent));

    var defaultProps$1 = {
        onGroup: function () { },
        draggingEnabled: false,
        isColumnGroupingEnabled: function () { return false; },
        onGroupDraft: function () { },
        onGroupDraftCancel: function () { },
    };
    // tslint:disable-next-line: max-line-length
    var GroupPanelLayoutBase = /*#__PURE__*/ (function (_super) {
        __extends(GroupPanelLayoutBase, _super);
        function GroupPanelLayoutBase(props) {
            var _this = _super.call(this, props) || this;
            _this.itemRefs = [];
            _this.draggingColumnName = null;
            _this.state = {
                sourceColumnName: null,
                targetItemIndex: -1,
            };
            _this.handleDragEvent = function (eventHandler, _a) {
                var payload = _a.payload, restArgs = __rest(_a, ["payload"]);
                var isColumnGroupingEnabled = _this.props.isColumnGroupingEnabled;
                var columnName = payload[0].columnName;
                if (isColumnGroupingEnabled(columnName)) {
                    eventHandler(__assign({ payload: payload }, restArgs));
                }
            };
            _this.onEnter = function (_a) {
                var payload = _a.payload;
                reactDom.flushSync(function () { return _this.setState({
                    sourceColumnName: payload[0].columnName,
                }); });
            };
            _this.onOver = function (_a) {
                var clientOffset = _a.clientOffset;
                var _b = _this.props, onGroupDraft = _b.onGroupDraft, items = _b.items;
                var _c = _this.state, sourceColumnName = _c.sourceColumnName, prevTargetItemIndex = _c.targetItemIndex;
                // eslint-disable-next-line react/no-find-dom-node
                var itemGeometries = _this.itemRefs
                    .map(function (ref) { return ref.getBoundingClientRect(); });
                var sourceItemIndex = items.findIndex(function (_a) {
                    var column = _a.column;
                    return column.name === sourceColumnName;
                });
                var targetItemIndex = dxGridCore.getGroupCellTargetIndex(itemGeometries, sourceItemIndex, clientOffset);
                if (prevTargetItemIndex === targetItemIndex)
                    return;
                onGroupDraft({
                    columnName: sourceColumnName,
                    groupIndex: targetItemIndex,
                });
                _this.setState({ targetItemIndex: targetItemIndex });
            };
            _this.onLeave = function () {
                var onGroupDraft = _this.props.onGroupDraft;
                var sourceColumnName = _this.state.sourceColumnName;
                if (!_this.draggingColumnName) {
                    _this.resetState();
                    return;
                }
                onGroupDraft({
                    columnName: sourceColumnName,
                    groupIndex: -1,
                });
                _this.setState({
                    targetItemIndex: -1,
                });
            };
            _this.onDrop = function () {
                var onGroup = _this.props.onGroup;
                var _a = _this.state, sourceColumnName = _a.sourceColumnName, targetItemIndex = _a.targetItemIndex;
                _this.resetState();
                onGroup({
                    columnName: sourceColumnName,
                    groupIndex: targetItemIndex,
                });
            };
            _this.onDragStart = function (columnName) {
                _this.draggingColumnName = columnName;
            };
            _this.onDragEnd = function () {
                _this.draggingColumnName = null;
                var _a = _this.state, sourceColumnName = _a.sourceColumnName, targetItemIndex = _a.targetItemIndex;
                var onGroup = _this.props.onGroup;
                if (sourceColumnName && targetItemIndex === -1) {
                    onGroup({
                        columnName: sourceColumnName,
                    });
                }
                _this.resetState();
            };
            return _this;
        }
        GroupPanelLayoutBase.prototype.resetState = function () {
            var onGroupDraftCancel = this.props.onGroupDraftCancel;
            onGroupDraftCancel();
            this.setState({
                sourceColumnName: null,
                targetItemIndex: -1,
            });
        };
        GroupPanelLayoutBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, items = _a.items, EmptyMessage = _a.emptyMessageComponent, Container = _a.containerComponent, Item = _a.itemComponent, draggingEnabled = _a.draggingEnabled, isColumnGroupingEnabled = _a.isColumnGroupingEnabled;
            this.itemRefs = [];
            var groupPanel = (items.length ? (React.createElement(Container, null, items.map(function (item) {
                var columnName = item.column.name;
                return (React.createElement(ItemLayout, { key: columnName, item: item, itemComponent: Item, itemRef: function (element) { return element && _this.itemRefs.push(element); }, draggingEnabled: draggingEnabled && isColumnGroupingEnabled(columnName), onDragStart: function () { return _this.onDragStart(columnName); }, onDragEnd: _this.onDragEnd }));
            }))) : (React.createElement(EmptyMessage, null)));
            return draggingEnabled
                ? (React.createElement(dxReactCore.DropTarget, { onEnter: function (args) { return _this.handleDragEvent(_this.onEnter, args); }, onOver: function (args) { return _this.handleDragEvent(_this.onOver, args); }, onLeave: function (args) { return _this.handleDragEvent(_this.onLeave, args); }, onDrop: function (args) { return _this.handleDragEvent(_this.onDrop, args); } }, groupPanel))
                : groupPanel;
        };
        GroupPanelLayoutBase.defaultProps = defaultProps$1;
        return GroupPanelLayoutBase;
    }(React.PureComponent));
    /** @internal */
    var GroupPanelLayout = GroupPanelLayoutBase;

    var defaultMessages$5 = {
        groupByColumn: 'Drag a column header here to group by that column',
    };
    var defaultProps$2 = {
        showSortingControls: false,
        showGroupingControls: false,
        messages: {},
    };
    var GroupingPanelRaw = /*#__PURE__*/ (function (_super) {
        __extends(GroupingPanelRaw, _super);
        function GroupingPanelRaw() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        GroupingPanelRaw.prototype.render = function () {
            var _a = this.props, LayoutComponent = _a.layoutComponent, Container = _a.containerComponent, Item = _a.itemComponent, EmptyMessage = _a.emptyMessageComponent, showSortingControls = _a.showSortingControls, showGroupingControls = _a.showGroupingControls, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$5), messages));
            var EmptyMessagePlaceholder = function (_a) {
                var forwardedRef = _a.forwardedRef;
                return (React.createElement(EmptyMessage, { getMessage: getMessage, forwardedRef: forwardedRef }));
            };
            var ItemPlaceholder = function (_a) {
                var item = _a.item, forwardedRef = _a.forwardedRef;
                var columnName = item.column.name;
                return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var sorting = _a.sorting, isColumnSortingEnabled = _a.isColumnSortingEnabled, isColumnGroupingEnabled = _a.isColumnGroupingEnabled;
                    var changeColumnGrouping = _b.changeColumnGrouping, changeColumnSorting = _b.changeColumnSorting;
                    var sortingEnabled = isColumnSortingEnabled && isColumnSortingEnabled(columnName);
                    var groupingEnabled = isColumnGroupingEnabled && isColumnGroupingEnabled(columnName);
                    return (React.createElement(Item, { forwardedRef: forwardedRef, item: item, sortingEnabled: sortingEnabled, groupingEnabled: groupingEnabled, showSortingControls: showSortingControls, sortingDirection: showSortingControls
                            ? dxGridCore.getColumnSortingDirection(sorting, columnName) : undefined, showGroupingControls: showGroupingControls, onGroup: function () { return changeColumnGrouping({ columnName: columnName }); }, onSort: function (_a) {
                            var direction = _a.direction, keepOther = _a.keepOther;
                            return changeColumnSorting({ columnName: columnName, direction: direction, keepOther: keepOther });
                        } }));
                }));
            };
            return (React.createElement(dxReactCore.Plugin, { name: "GroupingPanel", dependencies: [
                    { name: 'GroupingState' },
                    { name: 'Toolbar' },
                    { name: 'SortingState', optional: !showSortingControls },
                ] },
                React.createElement(dxReactCore.Template, { name: "toolbarContent" },
                    React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                        var columns = _a.columns, grouping = _a.grouping, draftGrouping = _a.draftGrouping, draggingEnabled = _a.draggingEnabled, isColumnGroupingEnabled = _a.isColumnGroupingEnabled, isDataRemote = _a.isDataRemote;
                        var changeColumnGrouping = _b.changeColumnGrouping, draftColumnGrouping = _b.draftColumnGrouping, cancelColumnGroupingDraft = _b.cancelColumnGroupingDraft, scrollToRow = _b.scrollToRow;
                        var onGroup = function (config) {
                            if (isDataRemote) {
                                scrollToRow(dxGridCore.TOP_POSITION);
                            }
                            changeColumnGrouping(config);
                        };
                        return React.createElement(LayoutComponent, { items: dxGridCore.groupingPanelItems(columns, grouping, draftGrouping), isColumnGroupingEnabled: isColumnGroupingEnabled, draggingEnabled: draggingEnabled, onGroup: onGroup, onGroupDraft: draftColumnGrouping, onGroupDraftCancel: cancelColumnGroupingDraft, itemComponent: ItemPlaceholder, emptyMessageComponent: EmptyMessagePlaceholder, containerComponent: Container });
                    }),
                    React.createElement(dxReactCore.TemplatePlaceholder, null))));
        };
        GroupingPanelRaw.defaultProps = defaultProps$2;
        GroupingPanelRaw.components = {
            layoutComponent: 'Layout',
            containerComponent: 'Container',
            itemComponent: 'Item',
            emptyMessageComponent: 'EmptyMessage',
        };
        return GroupingPanelRaw;
    }(React.PureComponent));
    /***
     * A plugin that renders the Grouping Panel in the Grid's header. This panel displays grouped
     * columns and allows a user to modify grouping options.Optionally, the plugin allows an end-user
     * to change grouped columns' sorting order and render sorting indicators.
     * */
    var GroupingPanel = dxReactCore.withComponents({ Layout: GroupPanelLayout })(GroupingPanelRaw);

    var DataTypeProviderBase = /*#__PURE__*/ (function (_super) {
        __extends(DataTypeProviderBase, _super);
        function DataTypeProviderBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        DataTypeProviderBase.prototype.render = function () {
            var _a = this.props, columnNames = _a.for, Formatter = _a.formatterComponent, Editor = _a.editorComponent, availableFilterOperations = _a.availableFilterOperations;
            var getAvailableFilterOperationsComputed = function (_a) {
                var getAvailableFilterOperations = _a.getAvailableFilterOperations;
                return dxGridCore.getAvailableFilterOperationsGetter(getAvailableFilterOperations, availableFilterOperations, columnNames);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "DataTypeProvider", key: columnNames.join('_') },
                React.createElement(dxReactCore.Getter, { name: "getAvailableFilterOperations", computed: getAvailableFilterOperationsComputed }),
                Formatter
                    ? (React.createElement(dxReactCore.Template, { name: "valueFormatter", predicate: function (_a) {
                            var column = _a.column;
                            return columnNames.includes(column.name);
                        } }, function (params) { return React.createElement(Formatter, __assign({}, params)); }))
                    : null,
                Editor
                    ? (React.createElement(dxReactCore.Template, { name: "valueEditor", predicate: function (_a) {
                            var column = _a.column;
                            return columnNames.includes(column.name);
                        } }, function (params) { return React.createElement(Editor, __assign({}, params)); }))
                    : null));
        };
        return DataTypeProviderBase;
    }(React.PureComponent));
    // tslint:disable-next-line: max-line-length
    /** A plugin that allows you to customize formatting options and editors depending on the data type. */
    var DataTypeProvider = DataTypeProviderBase;

    var pluginDependencies$g = [
        { name: 'Table' },
    ];
    var defaultMessages$6 = {
        noColumns: 'Nothing to show',
    };
    var columnExtensionValueGetter$4 = function (columnExtensions, defaultValue) { return dxGridCore.getColumnExtensionValueGetter(columnExtensions, 'togglingEnabled', defaultValue); };
    // tslint:disable-next-line: max-line-length
    var TableColumnVisibilityBase = /*#__PURE__*/ (function (_super) {
        __extends(TableColumnVisibilityBase, _super);
        function TableColumnVisibilityBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                hiddenColumnNames: props.hiddenColumnNames || props.defaultHiddenColumnNames,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                hiddenColumnNames: function () {
                    var onHiddenColumnNamesChange = _this.props.onHiddenColumnNamesChange;
                    return onHiddenColumnNamesChange;
                },
            });
            _this.toggleColumnVisibility = stateHelper.applyFieldReducer.bind(stateHelper, 'hiddenColumnNames', dxGridCore.toggleColumn);
            return _this;
        }
        TableColumnVisibilityBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.hiddenColumnNames, hiddenColumnNames = _a === void 0 ? prevState.hiddenColumnNames : _a;
            return {
                hiddenColumnNames: hiddenColumnNames,
            };
        };
        TableColumnVisibilityBase.prototype.render = function () {
            var _a = this.props, EmptyMessage = _a.emptyMessageComponent, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$6), messages));
            var hiddenColumnNames = this.state.hiddenColumnNames;
            var _b = this.props, columnExtensions = _b.columnExtensions, columnTogglingEnabled = _b.columnTogglingEnabled;
            return (React.createElement(dxReactCore.Plugin, { name: "TableColumnVisibility", dependencies: pluginDependencies$g },
                React.createElement(VisibleTableColumns, { hiddenColumnNames: hiddenColumnNames }),
                React.createElement(dxReactCore.Getter, { name: "isColumnTogglingEnabled", value: columnExtensionValueGetter$4(columnExtensions, columnTogglingEnabled) }),
                React.createElement(dxReactCore.Action, { name: "toggleColumnVisibility", action: this.toggleColumnVisibility }),
                React.createElement(dxReactCore.Template, { name: "table" }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var tableColumns = _a.tableColumns;
                    return (dxGridCore.tableDataColumnsExist(tableColumns)
                        ? React.createElement(dxReactCore.TemplatePlaceholder, null)
                        : (React.createElement(EmptyMessage, __assign({ getMessage: getMessage }, params))));
                })); })));
        };
        TableColumnVisibilityBase.defaultProps = {
            defaultHiddenColumnNames: [],
            messages: {},
            columnTogglingEnabled: true,
        };
        TableColumnVisibilityBase.components = {
            emptyMessageComponent: 'EmptyMessage',
        };
        return TableColumnVisibilityBase;
    }(React.PureComponent));
    TableColumnVisibilityBase.components = {
        emptyMessageComponent: 'EmptyMessage',
    };
    /* tslint:disable: max-line-length */
    /** A plugin that manages Grid columns' visibility. */
    var TableColumnVisibility = TableColumnVisibilityBase;
    /* tslint:enable: max-line-length */

    var ToolbarBase = /*#__PURE__*/ (function (_super) {
        __extends(ToolbarBase, _super);
        function ToolbarBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        ToolbarBase.prototype.render = function () {
            var _a = this.props, Root = _a.rootComponent, FlexibleSpaceComponent = _a.flexibleSpaceComponent;
            return (React.createElement(dxReactCore.Plugin, { name: "Toolbar" },
                React.createElement(dxReactCore.Template, { name: "header" }, function (params) { return (React.createElement(React.Fragment, null,
                    React.createElement(Root, __assign({}, params),
                        React.createElement(dxReactCore.TemplatePlaceholder, { name: "toolbarContent" })),
                    React.createElement(dxReactCore.TemplatePlaceholder, null))); }),
                React.createElement(dxReactCore.Template, { name: "toolbarContent" },
                    React.createElement(FlexibleSpaceComponent, null))));
        };
        ToolbarBase.components = {
            rootComponent: 'Root',
            flexibleSpaceComponent: 'FlexibleSpace',
        };
        return ToolbarBase;
    }(React.PureComponent));
    /** A plugin that renders the Grid toolbar. */
    var Toolbar = ToolbarBase;

    var TreeDataStateBase = /*#__PURE__*/ (function (_super) {
        __extends(TreeDataStateBase, _super);
        function TreeDataStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                expandedRowIds: props.expandedRowIds || props.defaultExpandedRowIds,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                expandedRowIds: function () {
                    var onExpandedRowIdsChange = _this.props.onExpandedRowIdsChange;
                    return onExpandedRowIdsChange;
                },
            });
            _this.toggleRowExpanded = stateHelper.applyFieldReducer
                .bind(stateHelper, 'expandedRowIds', dxGridCore.toggleRowExpanded);
            return _this;
        }
        TreeDataStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.expandedRowIds, expandedRowIds = _a === void 0 ? prevState.expandedRowIds : _a;
            return {
                expandedRowIds: expandedRowIds,
            };
        };
        TreeDataStateBase.prototype.render = function () {
            var expandedRowIds = this.state.expandedRowIds;
            return (React.createElement(dxReactCore.Plugin, { name: "TreeDataState" },
                React.createElement(dxReactCore.Getter, { name: "expandedRowIds", value: expandedRowIds }),
                ' ',
                React.createElement(dxReactCore.Action, { name: "toggleRowExpanded", action: this.toggleRowExpanded })));
        };
        TreeDataStateBase.defaultProps = {
            defaultExpandedRowIds: [],
        };
        return TreeDataStateBase;
    }(React.PureComponent));
    /** A plugin that manages the expanded state for tree rows. */
    var TreeDataState = TreeDataStateBase;

    var pluginDependencies$h = [
        { name: 'TreeDataState' },
    ];
    var expandedTreeRowsComputed = function (_a) {
        var rows = _a.rows, getRowId = _a.getRowId, expandedRowIds = _a.expandedRowIds;
        return dxGridCore.expandedTreeRows(rows, getRowId, expandedRowIds);
    };
    var getRowIdComputed$1 = function (_a) {
        var getRowId = _a.getRowId, rows = _a.rows;
        return dxGridCore.customTreeRowIdGetter(getRowId, rows);
    };
    var getRowLevelKeyComputed = function (_a) {
        var getRowLevelKey = _a.getRowLevelKey, rows = _a.rows;
        return dxGridCore.customTreeRowLevelKeyGetter(getRowLevelKey, rows);
    };
    var isTreeRowLeafComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.isTreeRowLeafGetter(rows);
    };
    var getTreeRowLevelComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.getTreeRowLevelGetter(rows);
    };
    var collapsedTreeRowsGetterComputed = function (_a) {
        var rows = _a.rows, getCollapsedRows = _a.getCollapsedRows;
        return dxGridCore.collapsedTreeRowsGetter(getCollapsedRows, rows);
    };
    var unwrappedTreeRowsComputed = function (_a) {
        var rows = _a.rows;
        return dxGridCore.unwrappedCustomTreeRows(rows);
    };
    var CustomTreeDataBase = /*#__PURE__*/ (function (_super) {
        __extends(CustomTreeDataBase, _super);
        function CustomTreeDataBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        CustomTreeDataBase.prototype.render = function () {
            var getChildRows = this.props.getChildRows;
            var treeRowsComputed = function (_a) {
                var rows = _a.rows;
                return dxGridCore.customTreeRowsWithMeta(rows, getChildRows);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "CustomTreeData", dependencies: pluginDependencies$h },
                React.createElement(dxReactCore.Getter, { name: "rows", computed: treeRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "getRowId", computed: getRowIdComputed$1 }),
                React.createElement(dxReactCore.Getter, { name: "getRowLevelKey", computed: getRowLevelKeyComputed }),
                React.createElement(dxReactCore.Getter, { name: "isTreeRowLeaf", computed: isTreeRowLeafComputed }),
                React.createElement(dxReactCore.Getter, { name: "getTreeRowLevel", computed: getTreeRowLevelComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: expandedTreeRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "getCollapsedRows", computed: collapsedTreeRowsGetterComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: unwrappedTreeRowsComputed })));
        };
        return CustomTreeDataBase;
    }(React.PureComponent));
    /***
     * A plugin that converts custom formatted tree data to a supported format and performs
     * local row expanding/collapsing.
     * */
    var CustomTreeData = CustomTreeDataBase;

    var TableTreeColumnBase = /*#__PURE__*/ (function (_super) {
        __extends(TableTreeColumnBase, _super);
        function TableTreeColumnBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableTreeColumnBase.prototype.render = function () {
            var _a = this.props, forColumnName = _a.for, showSelectionControls = _a.showSelectionControls, showSelectAll = _a.showSelectAll, Indent = _a.indentComponent, ExpandButton = _a.expandButtonComponent, Checkbox = _a.checkboxComponent, Content = _a.contentComponent, Cell = _a.cellComponent;
            return (React.createElement(dxReactCore.Plugin, { name: "TableTreeColumn", dependencies: [
                    { name: 'DataTypeProvider', optional: true },
                    { name: 'TreeDataState' },
                    { name: 'SelectionState', optional: !showSelectionControls },
                    { name: 'IntegratedSelection', optional: !showSelectAll },
                    { name: 'Table' },
                    { name: 'TableHeaderRow', optional: true },
                ], key: forColumnName },
                React.createElement(dxReactCore.Getter, { name: "tableTreeColumnName", value: forColumnName }),
                React.createElement(dxReactCore.Template, { name: "tableHeaderCellBefore", predicate: function (_a) {
                        var column = _a.column;
                        return column.name === forColumnName;
                    } },
                    React.createElement(ExpandButton, { visible: false, expanded: false, onToggle: function () { } }),
                    showSelectionControls && showSelectAll && (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                        var selectAllAvailable = _a.selectAllAvailable, allSelected = _a.allSelected, someSelected = _a.someSelected;
                        var toggleSelectAll = _b.toggleSelectAll;
                        return (React.createElement(Checkbox, { disabled: !selectAllAvailable, checked: allSelected, indeterminate: someSelected, onChange: toggleSelectAll }));
                    }))),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isTreeTableCell(tableRow, tableColumn, forColumnName);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var getCollapsedRows = _a.getCollapsedRows, expandedRowIds = _a.expandedRowIds, selection = _a.selection, isTreeRowLeaf = _a.isTreeRowLeaf, getTreeRowLevel = _a.getTreeRowLevel, getCellValue = _a.getCellValue;
                    var toggleRowExpanded = _b.toggleRowExpanded, toggleSelection = _b.toggleSelection;
                    var _c = params.tableRow, row = _c.row, rowId = _c.rowId;
                    var columnName = params.tableColumn.column.name;
                    var value = getCellValue(row, columnName);
                    var collapsedRows = getCollapsedRows(row);
                    return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "valueFormatter", params: {
                            value: value,
                            row: row,
                            column: params.tableColumn.column,
                        } }, function (content) { return (React.createElement(Cell, __assign({}, params, { row: row, column: params.tableColumn.column, value: value }),
                        React.createElement(Indent, { level: getTreeRowLevel(row) }),
                        React.createElement(ExpandButton, { visible: collapsedRows ? !!collapsedRows.length : !isTreeRowLeaf(row), expanded: expandedRowIds.indexOf(rowId) > -1, onToggle: function () { return toggleRowExpanded({ rowId: rowId }); } }),
                        showSelectionControls && (React.createElement(Checkbox, { disabled: false, checked: selection.indexOf(rowId) > -1, indeterminate: false, onChange: function () { return toggleSelection({ rowIds: [rowId] }); } })),
                        React.createElement(Content, null, content || value))); }));
                })); })));
        };
        TableTreeColumnBase.defaultProps = {
            showSelectionControls: false,
            showSelectAll: false,
        };
        TableTreeColumnBase.components = {
            cellComponent: 'Cell',
            contentComponent: 'Content',
            indentComponent: 'Indent',
            expandButtonComponent: 'ExpandButton',
            checkboxComponent: 'Checkbox',
        };
        return TableTreeColumnBase;
    }(React.PureComponent));
    /** A plugin that renders a table column with a toggle button and sorting indicators. */
    var TableTreeColumn = TableTreeColumnBase;

    var SearchStateBase = /*#__PURE__*/ (function (_super) {
        __extends(SearchStateBase, _super);
        function SearchStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                value: props.value || props.defaultValue,
            };
            var stateHelper = dxReactCore.createStateHelper(_this, {
                value: function () {
                    var onValueChange = _this.props.onValueChange;
                    return onValueChange;
                },
            });
            _this.changeValue = stateHelper.applyFieldReducer
                .bind(stateHelper, 'value', dxGridCore.changeSearchValue);
            return _this;
        }
        SearchStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.value, value = _a === void 0 ? prevState.value : _a;
            return {
                value: value,
            };
        };
        SearchStateBase.prototype.render = function () {
            var value = this.state.value;
            var filterExpressionComputed = function (_a) {
                var filterExpression = _a.filterExpression, columns = _a.columns;
                return dxGridCore.searchFilterExpression(value, columns, filterExpression);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "SearchState" },
                React.createElement(dxReactCore.Getter, { name: "filterExpression", computed: filterExpressionComputed }),
                React.createElement(dxReactCore.Getter, { name: "searchValue", value: value }),
                React.createElement(dxReactCore.Action, { name: "changeSearchValue", action: this.changeValue })));
        };
        SearchStateBase.defaultProps = {
            defaultValue: '',
        };
        return SearchStateBase;
    }(React.PureComponent));
    /** A plugin that manages the search state. */
    var SearchState = SearchStateBase;

    var pluginDependencies$i = [
        { name: 'Toolbar' },
        { name: 'SearchState' },
    ];
    var defaultMessages$7 = {
        searchPlaceholder: 'Search...',
    };
    var SearchPanelBase = /*#__PURE__*/ (function (_super) {
        __extends(SearchPanelBase, _super);
        function SearchPanelBase() {
            var _this = _super !== null && _super.apply(this, arguments) || this;
            _this.ref = React.createRef();
            return _this;
        }
        SearchPanelBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, Input = _a.inputComponent, messages = _a.messages;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$7), messages));
            return (React.createElement(dxReactCore.Plugin, { name: "SearchPanel", dependencies: pluginDependencies$i },
                React.createElement(dxReactCore.Template, { name: "toolbarContent" },
                    React.createElement(dxReactCore.TemplatePlaceholder, null),
                    React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                        var searchValue = _a.searchValue, isDataRemote = _a.isDataRemote;
                        var changeSearchValue = _b.changeSearchValue, scrollToRow = _b.scrollToRow, setSearchPanelRef = _b.setSearchPanelRef;
                        var onValueChange = function (value) {
                            if (isDataRemote) {
                                scrollToRow(dxGridCore.TOP_POSITION);
                            }
                            changeSearchValue(value);
                        };
                        if (setSearchPanelRef) {
                            setSearchPanelRef(_this.ref);
                        }
                        return React.createElement(Input, { value: searchValue, inputRef: _this.ref, onValueChange: onValueChange, getMessage: getMessage });
                    }))));
        };
        SearchPanelBase.defaultProps = {
            messages: {},
        };
        SearchPanelBase.components = {
            inputComponent: 'Input',
        };
        return SearchPanelBase;
    }(React.PureComponent));
    /** A plugin that renders the Search Panel. */
    var SearchPanel = SearchPanelBase;

    var tableHeaderRowsComputed$2 = function (_a) {
        var tableHeaderRows = _a.tableHeaderRows;
        return dxGridCore.tableHeaderRowsWithFixed(tableHeaderRows);
    };
    var tableHeaderColumnChainsComputed = function (_a) {
        var tableColumns = _a.tableColumns, tableHeaderRows = _a.tableHeaderRows, tableHeaderColumnChains = _a.tableHeaderColumnChains;
        return dxGridCore.tableHeaderColumnChainsWithFixed(tableHeaderColumnChains, tableHeaderRows, tableColumns);
    };
    var CellPlaceholder$2 = function (props) { return React.createElement(dxReactCore.TemplatePlaceholder, { params: props }); };
    var pluginDependencies$j = [
        { name: 'Table' },
        { name: 'TableBandHeader', optional: true },
        { name: 'TableColumnReordering', optional: true },
        { name: 'TableEditColumn', optional: true },
        { name: 'TableEditRow', optional: true },
        { name: 'TableFilterRow', optional: true },
        { name: 'TableGroupRow', optional: true },
        { name: 'TableHeaderRow', optional: true },
        { name: 'TableRowDetail', optional: true },
        { name: 'TableSelection', optional: true },
        { name: 'TableSummaryRow', optional: true },
        { name: 'TableTreeColumn', optional: true },
    ];
    // tslint:disable-next-line: max-line-length
    var TableFixedColumnsBase = /*#__PURE__*/ (function (_super) {
        __extends(TableFixedColumnsBase, _super);
        function TableFixedColumnsBase(props) {
            var _this = _super.call(this, props) || this;
            _this.state = {
                tableColumnDimensions: {},
            };
            return _this;
        }
        TableFixedColumnsBase.prototype.handleListenerSizeChange = function (key, width) {
            var tableColumnDimensions = this.state.tableColumnDimensions;
            if (tableColumnDimensions[key] !== width) {
                this.setState(function (state) {
                    var _a;
                    return ({
                        tableColumnDimensions: __assign(__assign({}, state.tableColumnDimensions), (_a = {}, _a[key] = width, _a)),
                    });
                });
            }
        };
        TableFixedColumnsBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, Cell = _a.cellComponent, ListenerRow = _a.listenerRowComponent, ListenerCell = _a.listenerCellComponent;
            var leftColumns = this.props.leftColumns;
            var rightColumns = this.props.rightColumns;
            var tableColumnsComputed = function (_a) {
                var tableColumns = _a.tableColumns;
                return dxGridCore.tableColumnsWithFixed(tableColumns, leftColumns, rightColumns);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "TableFixedColumns", dependencies: pluginDependencies$j },
                React.createElement(dxReactCore.Getter, { name: "tableHeaderRows", computed: tableHeaderRowsComputed$2 }),
                React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed }),
                React.createElement(dxReactCore.Getter, { name: "tableHeaderColumnChains", computed: tableHeaderColumnChainsComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableColumn = _a.tableColumn;
                        return !!tableColumn.fixed;
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var tableColumns = _a.tableColumns, tableHeaderColumnChains = _a.tableHeaderColumnChains, selection = _a.selection, focused = _a.focused, highlightSelectedRow = _a.highlightSelectedRow;
                    var selected = dxGridCore.isRowHighlighted(highlightSelectedRow, selection, params.tableRow, focused);
                    var tableColumnDimensions = _this.state.tableColumnDimensions;
                    var fixedColumnProps = dxGridCore.calculateFixedColumnProps(params, { leftColumns: leftColumns, rightColumns: rightColumns }, tableColumns, tableColumnDimensions, tableHeaderColumnChains);
                    return (React.createElement(Cell, __assign({}, params, fixedColumnProps, { component: CellPlaceholder$2, selected: selected })));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isFixedTableRow(tableRow);
                    } }, function (params) { return (React.createElement(ListenerRow, __assign({}, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isFixedTableRow(tableRow);
                    } }, function (params) { return (React.createElement(ListenerCell, __assign({}, params, { listen: !!params.tableColumn.fixed, onSizeChange: function (_a) {
                        var width = _a.width;
                        return _this.handleListenerSizeChange(params.tableColumn.key, width);
                    } }))); })));
        };
        TableFixedColumnsBase.components = {
            cellComponent: 'Cell',
            listenerRowComponent: 'ListenerRow',
            listenerCellComponent: 'ListenerCell',
        };
        TableFixedColumnsBase.defaultProps = {
            leftColumns: [],
            rightColumns: [],
        };
        return TableFixedColumnsBase;
    }(React.PureComponent));
    /** A plugin that enables you to fix columns to the left and right sides of the grid. */
    var TableFixedColumns = TableFixedColumnsBase;

    var groupSummaryItemsComputed = function (_a) {
        var groupSummaryItems = _a.groupSummaryItems;
        return dxGridCore.prepareGroupSummaryItems(groupSummaryItems);
    };
    var SummaryStateBase = /*#__PURE__*/ (function (_super) {
        __extends(SummaryStateBase, _super);
        function SummaryStateBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        SummaryStateBase.prototype.render = function () {
            var _a = this.props, totalItems = _a.totalItems, groupItems = _a.groupItems, treeItems = _a.treeItems;
            return (React.createElement(dxReactCore.Plugin, { name: "SummaryState" },
                React.createElement(dxReactCore.Getter, { name: "totalSummaryItems", value: totalItems }),
                React.createElement(dxReactCore.Getter, { name: "groupSummaryItems", value: groupItems }),
                React.createElement(dxReactCore.Getter, { name: "groupSummaryItems", computed: groupSummaryItemsComputed }),
                React.createElement(dxReactCore.Getter, { name: "treeSummaryItems", value: treeItems })));
        };
        SummaryStateBase.defaultProps = {
            totalItems: [],
            groupItems: [],
            treeItems: [],
        };
        return SummaryStateBase;
    }(React.PureComponent));
    /** A plugin that provides items for total, group, and tree summaries. */
    var SummaryState = SummaryStateBase;

    var pluginDependencies$k = [
        { name: 'SummaryState' },
        { name: 'IntegratedGrouping', optional: true },
    ];
    var IntegratedSummaryBase = /*#__PURE__*/ (function (_super) {
        __extends(IntegratedSummaryBase, _super);
        function IntegratedSummaryBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        IntegratedSummaryBase.prototype.render = function () {
            var calculator = this.props.calculator;
            var totalSummaryValuesComputed = function (_a) {
                var rows = _a.rows, totalSummaryItems = _a.totalSummaryItems, getCellValue = _a.getCellValue, getRowLevelKey = _a.getRowLevelKey, isGroupRow = _a.isGroupRow, getCollapsedRows = _a.getCollapsedRows;
                return dxGridCore.totalSummaryValues(rows, totalSummaryItems, getCellValue, getRowLevelKey, isGroupRow, getCollapsedRows, calculator);
            };
            var groupSummaryValuesComputed = function (_a) {
                var rows = _a.rows, groupSummaryItems = _a.groupSummaryItems, getCellValue = _a.getCellValue, getRowLevelKey = _a.getRowLevelKey, isGroupRow = _a.isGroupRow, getCollapsedRows = _a.getCollapsedRows;
                return dxGridCore.groupSummaryValues(rows, groupSummaryItems, getCellValue, getRowLevelKey, isGroupRow, getCollapsedRows, calculator);
            };
            var treeSummaryValuesComputed = function (_a) {
                var rows = _a.rows, treeSummaryItems = _a.treeSummaryItems, getCellValue = _a.getCellValue, getRowLevelKey = _a.getRowLevelKey, isGroupRow = _a.isGroupRow, getRowId = _a.getRowId;
                return dxGridCore.treeSummaryValues(rows, treeSummaryItems, getCellValue, getRowLevelKey, isGroupRow, getRowId, calculator);
            };
            return (React.createElement(dxReactCore.Plugin, { name: "IntegratedSummary", dependencies: pluginDependencies$k },
                React.createElement(dxReactCore.Getter, { name: "totalSummaryValues", computed: totalSummaryValuesComputed }),
                React.createElement(dxReactCore.Getter, { name: "groupSummaryValues", computed: groupSummaryValuesComputed }),
                React.createElement(dxReactCore.Getter, { name: "treeSummaryValues", computed: treeSummaryValuesComputed })));
        };
        IntegratedSummaryBase.defaultCalculator = dxGridCore.defaultSummaryCalculator;
        return IntegratedSummaryBase;
    }(React.PureComponent));
    /** A plugin that performs a built-in data summary calculation. */
    var IntegratedSummary = IntegratedSummaryBase;

    var pluginDependencies$l = [
        { name: 'SummaryState' },
    ];
    var CustomSummaryBase = /*#__PURE__*/ (function (_super) {
        __extends(CustomSummaryBase, _super);
        function CustomSummaryBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        CustomSummaryBase.prototype.render = function () {
            var _a = this.props, totalValues = _a.totalValues, groupValues = _a.groupValues, treeValues = _a.treeValues;
            return (React.createElement(dxReactCore.Plugin, { name: "CustomSummary", dependencies: pluginDependencies$l },
                React.createElement(dxReactCore.Getter, { name: "totalSummaryValues", value: totalValues }),
                React.createElement(dxReactCore.Getter, { name: "groupSummaryValues", value: groupValues }),
                React.createElement(dxReactCore.Getter, { name: "treeSummaryValues", value: treeValues })));
        };
        return CustomSummaryBase;
    }(React.PureComponent));
    /** A plugin that allows you to calculate a custom summary. */
    var CustomSummary = CustomSummaryBase;

    var dependencies$1 = [
        { name: 'DataTypeProvider', optional: true },
        { name: 'SummaryState' },
        { name: 'CustomSummary', optional: true },
        { name: 'IntegratedSummary', optional: true },
        { name: 'Table' },
        { name: 'TableTreeColumn', optional: true },
    ];
    var tableBodyRowsComputed$2 = function (_a) {
        var tableBodyRows = _a.tableBodyRows, getRowLevelKey = _a.getRowLevelKey, isGroupRow = _a.isGroupRow, getRowId = _a.getRowId, groupSummaryItems = _a.groupSummaryItems, treeSummaryItems = _a.treeSummaryItems;
        return dxGridCore.tableRowsWithSummaries(tableBodyRows, groupSummaryItems, treeSummaryItems, getRowLevelKey, isGroupRow, getRowId);
    };
    var tableFooterRowsComputed = function (_a) {
        var tableFooterRows = _a.tableFooterRows, totalSummaryItems = _a.totalSummaryItems;
        return totalSummaryItems.length
            ? dxGridCore.tableRowsWithTotalSummaries(tableFooterRows)
            : tableFooterRows;
    };
    var TableSummaryRowBase = /*#__PURE__*/ (function (_super) {
        __extends(TableSummaryRowBase, _super);
        function TableSummaryRowBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableSummaryRowBase.prototype.renderContent = function (column, columnSummaries) {
            var _a = this.props, formatlessSummaryTypes = _a.formatlessSummaryTypes, Item = _a.itemComponent, messages = _a.messages;
            return (React.createElement(TableSummaryContent, { column: column, columnSummaries: columnSummaries, formatlessSummaryTypes: formatlessSummaryTypes, itemComponent: Item, messages: messages }));
        };
        TableSummaryRowBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, TotalRow = _a.totalRowComponent, GroupRow = _a.groupRowComponent, TreeRow = _a.treeRowComponent, TotalCell = _a.totalCellComponent, GroupCell = _a.groupCellComponent, TreeCell = _a.treeCellComponent, TreeColumnCell = _a.treeColumnCellComponent, TreeColumnContent = _a.treeColumnContentComponent, TreeColumnIndent = _a.treeColumnIndentComponent;
            return (React.createElement(dxReactCore.Plugin, { name: "TableSummaryRow", dependencies: dependencies$1 },
                React.createElement(dxReactCore.Getter, { name: "tableBodyRows", computed: tableBodyRowsComputed$2 }),
                React.createElement(dxReactCore.Getter, { name: "tableFooterRows", computed: tableFooterRowsComputed }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isTotalSummaryTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var totalSummaryItems = _a.totalSummaryItems, totalSummaryValues = _a.totalSummaryValues;
                    var columnSummaries = dxGridCore.getColumnSummaries(totalSummaryItems, params.tableColumn.column.name, totalSummaryValues);
                    return (React.createElement(TotalCell, __assign({}, params, { column: params.tableColumn.column }), _this.renderContent(params.tableColumn.column, columnSummaries)));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isGroupSummaryTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var groupSummaryItems = _a.groupSummaryItems, groupSummaryValues = _a.groupSummaryValues;
                    var columnSummaries = dxGridCore.getColumnSummaries(groupSummaryItems, params.tableColumn.column.name, groupSummaryValues[params.tableRow.row.compoundKey], function (summaryItem) { return dxGridCore.isFooterSummary(summaryItem); });
                    return (React.createElement(GroupCell, __assign({}, params, { column: params.tableColumn.column }), _this.renderContent(params.tableColumn.column, columnSummaries)));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                        var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                        return dxGridCore.isTreeSummaryTableCell(tableRow, tableColumn);
                    } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                    var treeSummaryItems = _a.treeSummaryItems, treeSummaryValues = _a.treeSummaryValues, tableTreeColumnName = _a.tableTreeColumnName, getRowId = _a.getRowId, getTreeRowLevel = _a.getTreeRowLevel;
                    var columnSummaries = dxGridCore.getColumnSummaries(treeSummaryItems, params.tableColumn.column.name, treeSummaryValues[getRowId(params.tableRow.row)]);
                    if (tableTreeColumnName === params.tableColumn.column.name) {
                        return (React.createElement(TreeColumnCell, __assign({}, params, { column: params.tableColumn.column }),
                            React.createElement(TreeColumnIndent, { level: getTreeRowLevel(params.tableRow.row) }),
                            React.createElement(TreeColumnContent, null, _this.renderContent(params.tableColumn.column, columnSummaries))));
                    }
                    return (React.createElement(TreeCell, __assign({}, params, { column: params.tableColumn.column }), _this.renderContent(params.tableColumn.column, columnSummaries)));
                })); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isTotalSummaryTableRow(tableRow);
                    } }, function (params) { return (React.createElement(TotalRow, __assign({}, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isGroupSummaryTableRow(tableRow);
                    } }, function (params) { return (React.createElement(GroupRow, __assign({}, params))); }),
                React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isTreeSummaryTableRow(tableRow);
                    } }, function (params) { return (React.createElement(TreeRow, __assign({}, params))); })));
        };
        TableSummaryRowBase.TREE_ROW_TYPE = dxGridCore.TABLE_TREE_SUMMARY_TYPE;
        TableSummaryRowBase.GROUP_ROW_TYPE = dxGridCore.TABLE_GROUP_SUMMARY_TYPE;
        TableSummaryRowBase.TOTAL_ROW_TYPE = dxGridCore.TABLE_TOTAL_SUMMARY_TYPE;
        TableSummaryRowBase.defaultProps = {
            formatlessSummaryTypes: [],
            messages: {},
        };
        TableSummaryRowBase.components = {
            totalRowComponent: 'TotalRow',
            groupRowComponent: 'GroupRow',
            treeRowComponent: 'TreeRow',
            totalCellComponent: 'TotalCell',
            groupCellComponent: 'GroupCell',
            treeCellComponent: 'TreeCell',
            treeColumnCellComponent: 'TableTreeCell',
            treeColumnContentComponent: 'TableTreeContent',
            treeColumnIndentComponent: 'TableTreeIndent',
            itemComponent: 'Item',
        };
        return TableSummaryRowBase;
    }(React.PureComponent));
    /** A plugin that renders table rows that display a total, group, and tree summary. */
    var TableSummaryRow = TableSummaryRowBase;

    var virtualRowsComputed = function (_a) {
        var skip = _a.skip, rows = _a.rows, virtualRowsCache = _a.virtualRowsCache;
        return dxGridCore.virtualRowsWithCache(skip, rows, virtualRowsCache);
    };
    var rowsComputed = function (_a) {
        var virtualRows = _a.virtualRows, availableRowCount = _a.availableRowCount;
        return dxGridCore.plainRows(virtualRows, availableRowCount);
    };
    var loadedRowsStartComputed = function (_a) {
        var virtualRows = _a.virtualRows;
        return dxGridCore.loadedRowsStart(virtualRows);
    };
    // tslint:disable-next-line: max-line-length
    var VirtualTableStateBase = /*#__PURE__*/ (function (_super) {
        __extends(VirtualTableStateBase, _super);
        function VirtualTableStateBase(props) {
            var _this = _super.call(this, props) || this;
            _this.requestTimer = 0;
            _this.setViewport = function (viewport, _a, _b) {
                var virtualRows = _a.virtualRows;
                var requestNextPage = _b.requestNextPage;
                var pageSize = _this.props.pageSize;
                var referenceIndex = dxGridCore.getReferenceIndex(viewport);
                if (dxGridCore.needFetchMorePages(virtualRows, referenceIndex, pageSize)) {
                    requestNextPage({ referenceIndex: referenceIndex });
                }
            };
            _this.requestNextPageAction = function (_a, _b) {
                var referenceIndex = _a.referenceIndex, forceReload = _a.forceReload;
                var virtualRows = _b.virtualRows;
                var _c = _this.props, pageSize = _c.pageSize, totalRowCount = _c.totalRowCount, infiniteScrolling = _c.infiniteScrolling;
                var _d = _this.state, requestedStartIndex = _d.requestedStartIndex, requestedEndIndex = _d.requestedEndIndex;
                var actualVirtualRows = forceReload ? dxGridCore.emptyVirtualRows : virtualRows;
                var _e = dxGridCore.getRequestMeta(referenceIndex, virtualRows, pageSize, totalRowCount, forceReload, infiniteScrolling), requestedRange = _e.requestedRange, actualBounds = _e.actualBounds;
                if (forceReload || dxGridCore.shouldSendRequest(requestedRange, requestedStartIndex, requestedEndIndex)) {
                    _this.requestNextPage(requestedRange, actualVirtualRows, actualBounds);
                }
            };
            _this.clearRowsCacheAction = function (_, __, _a) {
                var requestNextPage = _a.requestNextPage;
                _this.setState({
                    virtualRowsCache: dxGridCore.emptyVirtualRows,
                });
                requestNextPage({ forceReload: true });
            };
            _this.resetVirtualTablePosition = function () { return _this.requestFirstPage(); };
            _this.state = {
                virtualRowsCache: dxGridCore.emptyVirtualRows,
                requestedStartIndex: 0,
                availableRowCount: props.totalRowCount || 0,
                requestedEndIndex: 2 * props.pageSize,
            };
            return _this;
        }
        VirtualTableStateBase.prototype.requestNextPage = function (requestedRange, virtualRows, actualBounds) {
            var _this = this;
            var _a = this.props, getRows = _a.getRows, infiniteScrolling = _a.infiniteScrolling, totalRowCount = _a.totalRowCount;
            var stateAvailableCount = this.state.availableRowCount;
            if (this.requestTimer !== 0) {
                clearTimeout(this.requestTimer);
            }
            this.requestTimer = window.setTimeout(function () {
                var requestedStartIndex = requestedRange.start, end = requestedRange.end;
                var loadCount = end - requestedStartIndex;
                var virtualRowsCache = dxGridCore.trimRowsToInterval(virtualRows, actualBounds);
                var availableRowCount = dxGridCore.getAvailableRowCount(infiniteScrolling, actualBounds.end, stateAvailableCount, totalRowCount);
                getRows(requestedStartIndex, loadCount);
                _this.setState({
                    virtualRowsCache: virtualRowsCache,
                    availableRowCount: availableRowCount,
                    requestedStartIndex: requestedStartIndex,
                    requestedEndIndex: end,
                });
            }, 50);
        };
        VirtualTableStateBase.prototype.requestFirstPage = function () {
            var _this = this;
            var _a = this.props, getRows = _a.getRows, pageSize = _a.pageSize;
            var startIndex = 0;
            var endIndex = 2 * pageSize;
            if (this.requestTimer !== 0) {
                clearTimeout(this.requestTimer);
            }
            this.requestTimer = window.setTimeout(function () {
                getRows(startIndex, endIndex);
                _this.setState({
                    virtualRowsCache: dxGridCore.emptyVirtualRows,
                    requestedStartIndex: startIndex,
                    requestedEndIndex: endIndex,
                });
            }, 50);
        };
        VirtualTableStateBase.getDerivedStateFromProps = function (nextProps, prevState) {
            var _a = nextProps.availableRowCount, prevAvailableRowCount = _a === void 0 ? prevState.availableRowCount : _a, totalRowCount = nextProps.totalRowCount, pageSize = nextProps.pageSize, infiniteScrolling = nextProps.infiniteScrolling;
            var prevRequestedStartIndex = prevState.requestedStartIndex, prevVirtualRowCache = prevState.virtualRowsCache;
            var availableRowCount = dxGridCore.getAvailableRowCount(infiniteScrolling, pageSize * 2, prevAvailableRowCount, totalRowCount);
            var requestedStartIndex = Math.max(Math.min(prevRequestedStartIndex, availableRowCount - pageSize), 0);
            var virtualRowsCache = prevRequestedStartIndex === requestedStartIndex
                ? prevVirtualRowCache
                : dxGridCore.emptyVirtualRows;
            return {
                availableRowCount: availableRowCount,
                requestedStartIndex: requestedStartIndex,
                virtualRowsCache: virtualRowsCache,
            };
        };
        VirtualTableStateBase.prototype.componentDidMount = function () {
            var _a = this.props, getRows = _a.getRows, pageSize = _a.pageSize, infiniteScrolling = _a.infiniteScrolling, totalRowCount = _a.totalRowCount;
            getRows(0, 2 * pageSize);
            var newRowCount = infiniteScrolling ? 2 * pageSize : totalRowCount;
            this.setState({
                availableRowCount: newRowCount,
            });
        };
        VirtualTableStateBase.prototype.componentWillUnmount = function () {
            if (this.requestTimer !== 0) {
                window.clearTimeout(this.requestTimer);
            }
        };
        VirtualTableStateBase.prototype.render = function () {
            var _a = this.state, virtualRowsCache = _a.virtualRowsCache, availableRowCount = _a.availableRowCount;
            var _b = this.props, skip = _b.skip, pageSize = _b.pageSize, loading = _b.loading, infiniteScrolling = _b.infiniteScrolling;
            return (React.createElement(dxReactCore.Plugin, { name: "VirtualTableState" },
                React.createElement(dxReactCore.Getter, { name: "isDataRemote", value: true }),
                React.createElement(dxReactCore.Getter, { name: "isDataLoading", value: loading }),
                React.createElement(dxReactCore.Getter, { name: "isScrollingInfinite", value: infiniteScrolling }),
                React.createElement(dxReactCore.Getter, { name: "skip", value: skip }),
                React.createElement(dxReactCore.Getter, { name: "virtualRowsCache", value: virtualRowsCache }),
                React.createElement(dxReactCore.Getter, { name: "pageSize", value: pageSize }),
                React.createElement(dxReactCore.Getter, { name: "availableRowCount", value: availableRowCount }),
                React.createElement(dxReactCore.Getter, { name: "virtualRows", computed: virtualRowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "rows", computed: rowsComputed }),
                React.createElement(dxReactCore.Getter, { name: "loadedRowsStart", computed: loadedRowsStartComputed }),
                React.createElement(dxReactCore.Action, { name: "requestNextPage", action: this.requestNextPageAction }),
                React.createElement(dxReactCore.Action, { name: "setViewport", action: this.setViewport }),
                React.createElement(dxReactCore.Action, { name: "clearRowCache", action: this.clearRowsCacheAction }),
                React.createElement(dxReactCore.Action, { name: "changeColumnSorting", action: this.clearRowsCacheAction }),
                React.createElement(dxReactCore.Action, { name: "changeColumnFilter", action: this.resetVirtualTablePosition }),
                React.createElement(dxReactCore.Action, { name: "changeSearchValue", action: this.resetVirtualTablePosition }),
                React.createElement(dxReactCore.Action, { name: "changeColumnGrouping", action: this.resetVirtualTablePosition })));
        };
        VirtualTableStateBase.defaultProps = {
            pageSize: 100,
        };
        return VirtualTableStateBase;
    }(React.PureComponent));
    var VirtualTableState = VirtualTableStateBase;

    var pluginDependencies$m = [
        { name: 'EditingState' },
        { name: 'Table' },
        { name: 'DataTypeProvider', optional: true },
    ];
    var rowsWithEditingCellsComputed = function (_a) {
        var tableBodyRows = _a.tableBodyRows, editingCells = _a.editingCells;
        return dxGridCore.rowsWithEditingCells(tableBodyRows, editingCells);
    };
    var columnsWithEditingCellsComputed = function (_a) {
        var tableColumns = _a.tableColumns, editingCells = _a.editingCells;
        return dxGridCore.columnsWithEditingCells(tableColumns, editingCells);
    };
    /* tslint:disable-next-line max-line-length*/
    var INLINE_CELL_EDITING_ERROR = 'The startEditAction property of the InlineCellEditing plugin is given an invalid value.';
    // tslint:disable-next-line: max-line-length
    var TableInlineCellEditingBase = function (props) {
        var EditCell = props.cellComponent, startEditAction = props.startEditAction, selectTextOnEditStart = props.selectTextOnEditStart;
        return (React.createElement(dxReactCore.Plugin, { name: "TableInlineCellEditing", dependencies: pluginDependencies$m },
            React.createElement(dxReactCore.Getter, { name: "tableBodyRows", computed: rowsWithEditingCellsComputed }),
            React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: columnsWithEditingCellsComputed }),
            React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                    var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                    return tableRow.type === dxGridCore.TABLE_DATA_TYPE &&
                        tableColumn.type === dxGridCore.TABLE_DATA_TYPE;
                } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                var _c;
                var startEditCells = _b.startEditCells;
                var rowId = params.tableRow.rowId, column = params.tableColumn.column;
                var columnName = column.name;
                if (startEditAction !== 'click' && startEditAction !== 'doubleClick') {
                    throw new Error(INLINE_CELL_EDITING_ERROR);
                }
                var startEditCellCallback = function () {
                    return startEditCells({
                        editingCells: [{ rowId: rowId, columnName: columnName }],
                    });
                };
                var eventName = startEditAction === 'click' ? 'onClick' : 'onDoubleClick';
                var newParams = __assign(__assign({}, params), (_c = {}, _c[eventName] = startEditCellCallback, _c));
                return React.createElement(dxReactCore.TemplatePlaceholder, { params: newParams });
            })); }),
            React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                    var tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                    return tableRow.hasEditCell && tableColumn.hasEditCell;
                } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                var getCellValue = _a.getCellValue, createRowChange = _a.createRowChange, rowChanges = _a.rowChanges, isColumnEditingEnabled = _a.isColumnEditingEnabled;
                var changeRow = _b.changeRow, stopEditCells = _b.stopEditCells, commitChangedRows = _b.commitChangedRows, cancelChangedRows = _b.cancelChangedRows;
                var _c = params.tableRow, rowId = _c.rowId, row = _c.row, column = params.tableColumn.column;
                var columnName = column.name;
                var changedRow = __assign(__assign({}, row), dxGridCore.getRowChange(rowChanges, rowId));
                var value = getCellValue(changedRow, columnName);
                var onValueChange = function (newValue) {
                    var changeArgs = {
                        rowId: rowId,
                        change: createRowChange(changedRow, newValue, columnName),
                    };
                    changeRow(changeArgs);
                };
                var onKeyDown = function (_a) {
                    var key = _a.key;
                    if (key === 'Enter') {
                        commitChangedRows({ rowIds: [rowId] });
                        stopEditCells({ editingCells: [{ rowId: rowId, columnName: columnName }] });
                    }
                    else if (key === 'Escape') {
                        cancelChangedRows({ rowIds: [rowId] });
                        stopEditCells({ editingCells: [{ rowId: rowId, columnName: columnName }] });
                    }
                };
                var onBlur = function () {
                    commitChangedRows({ rowIds: [rowId] });
                    stopEditCells({ editingCells: [{ rowId: rowId, columnName: columnName }] });
                };
                var onFocus = selectTextOnEditStart ? function (e) { return e.target.select(); } : function () { };
                var editingEnabled = isColumnEditingEnabled(columnName);
                return (React.createElement(dxReactCore.TemplatePlaceholder, { name: "valueEditor", params: {
                        column: column,
                        row: row,
                        value: value,
                        onValueChange: onValueChange,
                        disabled: !editingEnabled,
                    } }, function (content) { return (React.createElement(EditCell, __assign({}, params, { row: row, column: column, value: value, editingEnabled: editingEnabled, onValueChange: onValueChange, autoFocus: true, onKeyDown: onKeyDown, onBlur: onBlur, onFocus: onFocus }), content)); }));
            })); })));
    };
    TableInlineCellEditingBase.components = {
        cellComponent: 'Cell',
    };
    TableInlineCellEditingBase.defaultProps = {
        startEditAction: 'click',
        selectTextOnEditStart: false,
    };
    // tslint:disable-next-line: max-line-length
    var TableInlineCellEditing = TableInlineCellEditingBase;

    var defaultMessages$8 = {
        showExportMenu: 'Export',
        exportAll: 'Export all data',
        exportSelected: 'Export selected rows',
    };
    var ExportPanelBase = /*#__PURE__*/ (function (_super) {
        __extends(ExportPanelBase, _super);
        function ExportPanelBase() {
            var _this = _super !== null && _super.apply(this, arguments) || this;
            _this.state = { visible: false };
            _this.setButtonRef = function (button) { return _this.button = button; };
            _this.handleToggle = function () {
                var visible = _this.state.visible;
                _this.setState({ visible: !visible });
            };
            _this.handleHide = function () { return _this.setState({ visible: false }); };
            return _this;
        }
        ExportPanelBase.prototype.render = function () {
            var _this = this;
            var _a = this.props, ToggleButton = _a.toggleButtonComponent, Menu = _a.menuComponent, MenuItem = _a.menuItemComponent, messages = _a.messages, startExport = _a.startExport;
            var visible = this.state.visible;
            var getMessage = dxCore.getMessagesFormatter(__assign(__assign({}, defaultMessages$8), messages));
            return (React.createElement(dxReactCore.Plugin, { name: "ExportPanel", dependencies: [
                    { name: 'SelectionState', optional: true },
                    { name: 'Toolbar' },
                ] },
                React.createElement(dxReactCore.Template, { name: "toolbarContent" },
                    React.createElement(dxReactCore.TemplatePlaceholder, null),
                    React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                        var selection = _a.selection;
                        return (React.createElement(React.Fragment, null,
                            React.createElement(ToggleButton, { buttonRef: _this.setButtonRef, onToggle: _this.handleToggle, getMessage: getMessage }),
                            React.createElement(Menu, { visible: visible, onHide: _this.handleHide, target: _this.button },
                                React.createElement(MenuItem, { key: "exportAll", text: getMessage('exportAll'), onClick: function () {
                                        _this.handleHide();
                                        startExport();
                                    } }),
                                (selection === null || selection === void 0 ? void 0 : selection.length) ? (React.createElement(MenuItem, { key: "exportSelected", text: getMessage('exportSelected'), onClick: function () {
                                        _this.handleHide();
                                        startExport({ selectedOnly: true });
                                    } })) : null)));
                    }))));
        };
        ExportPanelBase.components = {
            toggleButtonComponent: 'ToggleButton',
            menuComponent: 'Menu',
            menuItemComponent: 'MenuItem',
        };
        return ExportPanelBase;
    }(React.PureComponent));
    var ExportPanel = ExportPanelBase;

    var CellPlaceholder$3 = function (props) { return React.createElement(dxReactCore.TemplatePlaceholder, { params: props }); };
    var RowPlaceholder$1 = function (props) { return React.createElement(dxReactCore.TemplatePlaceholder, { params: props }); };
    var TableKeyboardNavigationCore = /*#__PURE__*/ (function (_super) {
        __extends(TableKeyboardNavigationCore, _super);
        function TableKeyboardNavigationCore(props) {
            var _this = _super.call(this, props) || this;
            _this.elements = {};
            var focusedCell = props.focusedCell || props.defaultFocusedCell;
            _this.state = {
                focusedElement: focusedCell ? __assign({ part: dxGridCore.TABLE_DATA_TYPE.toString() }, focusedCell) : focusedCell,
            };
            _this.handleKeyDownOnWidget = _this.handleKeyDownOnWidget.bind(_this);
            _this.updateRef = _this.updateRef.bind(_this);
            _this.setFocusedElement = _this.setFocusedElement.bind(_this);
            _this.setSearchPanelRef = _this.setSearchPanelRef.bind(_this);
            return _this;
        }
        TableKeyboardNavigationCore.getDerivedStateFromProps = function (props, state) {
            var focusedCell = props.focusedCell !== undefined ? props.focusedCell : state.focusedElement;
            return {
                focusedElement: focusedCell ? __assign({ part: dxGridCore.TABLE_DATA_TYPE.toString() }, focusedCell) : undefined,
            };
        };
        TableKeyboardNavigationCore.prototype.componentDidMount = function () {
            this.props.rootRef.current.addEventListener('keydown', this.handleKeyDownOnWidget);
        };
        TableKeyboardNavigationCore.prototype.componentWillUnmount = function () {
            this.props.rootRef.current.removeEventListener('keydown', this.handleKeyDownOnWidget);
        };
        TableKeyboardNavigationCore.prototype.pushRef = function (ref, key1, key2) {
            var focusedElement = this.state.focusedElement;
            var tableColumns = this.props.tableColumns;
            if (!this.elements[key1]) {
                this.elements[key1] = [];
            }
            if (!this.elements[key1][key2]) {
                this.elements[key1][key2] = [];
            }
            this.elements[key1][key2].push(ref);
            if ((focusedElement === null || focusedElement === void 0 ? void 0 : focusedElement.rowKey) === key1 && (focusedElement === null || focusedElement === void 0 ? void 0 : focusedElement.columnKey) === key2) {
                dxGridCore.focus(this.elements, focusedElement, undefined, this.props.onFocusedCellChange);
            }
            if (key1.toString().includes(dxGridCore.TABLE_ADDED_TYPE.toString()) &&
                key2 === tableColumns[0].key) {
                this.changeFocusedElement({
                    part: dxGridCore.TABLE_DATA_TYPE.toString(),
                    columnKey: key2,
                    rowKey: key1,
                }, focusedElement);
            }
        };
        TableKeyboardNavigationCore.prototype.setSearchPanelRef = function (ref) {
            this.searchPanelRef = ref;
        };
        TableKeyboardNavigationCore.prototype.removeRef = function (key1, key2) {
            delete this.elements[key1][key2];
            if (Object.keys(this.elements[key1]).length === 0) {
                delete this.elements[key1];
            }
        };
        TableKeyboardNavigationCore.prototype.updateRef = function (_a) {
            var ref = _a.ref, key1 = _a.key1, key2 = _a.key2, action = _a.action;
            if (action === 'add') {
                this.pushRef(ref, key1, key2);
            }
            else {
                this.removeRef(key1, key2);
            }
        };
        TableKeyboardNavigationCore.prototype.changeFocusedElement = function (focusedCell, prevFocusedCell) {
            var onFocusedCellChange = this.props.onFocusedCellChange;
            this.setState({
                focusedElement: focusedCell,
            });
            dxGridCore.focus(this.elements, focusedCell, prevFocusedCell, onFocusedCellChange);
        };
        TableKeyboardNavigationCore.prototype.handleKeyDownOnWidget = function (event) {
            var _a;
            var focusedElement = this.state.focusedElement;
            var _b = this.props, tableColumns = _b.tableColumns, tableBodyRows = _b.tableBodyRows, tableHeaderRows = _b.tableHeaderRows, expandedRowIds = _b.expandedRowIds, scrollToColumn = _b.scrollToColumn, inlineEditing = _b.inlineEditing;
            if (event.key === 'f' && (event.ctrlKey || event.metaKey)) {
                if (this.searchPanelRef) {
                    event.preventDefault();
                    (_a = this.searchPanelRef.current) === null || _a === void 0 ? void 0 : _a.click();
                }
                if (focusedElement) {
                    this.changeFocusedElement(undefined, focusedElement);
                }
                return;
            }
            if (focusedElement && !dxGridCore.isCellExist(this.elements, focusedElement) && event.key === 'Tab') {
                var focusedCell = dxGridCore.getClosestCellByRow(tableBodyRows, focusedElement, this.elements);
                event.preventDefault();
                this.changeFocusedElement(focusedCell, focusedElement);
                return;
            }
            if (focusedElement || dxGridCore.isTabArrowUpDown(event)) {
                var _c = dxGridCore.getNextFocusedCell(tableColumns, tableBodyRows, tableHeaderRows, expandedRowIds, this.elements, event, inlineEditing, focusedElement, scrollToColumn), element = _c.element, scrolling = _c.scrolling;
                if (element) {
                    if (scrolling) {
                        scrollToColumn(scrolling === 'left' ? dxGridCore.LEFT_POSITION : dxGridCore.RIGHT_POSITION);
                    }
                    event.preventDefault();
                    this.changeFocusedElement(element, focusedElement);
                }
                else if (dxGridCore.isTabArrowUpDown(event) && focusedElement) {
                    this.changeFocusedElement(undefined, focusedElement);
                }
            }
        };
        TableKeyboardNavigationCore.prototype.setFocusedElement = function (_a) {
            var key1 = _a.key1, key2 = _a.key2, event = _a.event;
            var focusedElement = this.state.focusedElement;
            var inlineEditing = this.props.inlineEditing;
            if (key1 === 'paging' || key1 === 'toolbar') {
                this.changeFocusedElement(undefined, focusedElement);
            }
            else if (key2.includes(dxGridCore.TABLE_FLEX_TYPE.toString())) {
                var columnKey = this.props.tableColumns[0].key;
                this.changeFocusedElement({
                    rowKey: key1,
                    columnKey: columnKey,
                    index: -1,
                    part: dxGridCore.getPart(key1),
                }, focusedElement);
            }
            else {
                var part = dxGridCore.getPart(key1);
                this.changeFocusedElement({
                    rowKey: key1,
                    columnKey: key2,
                    index: dxGridCore.getIndexToFocus(key1, key2, this.elements, event, inlineEditing, part),
                    part: part,
                }, focusedElement);
            }
        };
        TableKeyboardNavigationCore.prototype.render = function () {
            var _this = this;
            var _a = this.props, Cell = _a.cellComponent, Row = _a.rowComponent, focusedRowEnabled = _a.focusedRowEnabled, tableBodyRows = _a.tableBodyRows;
            var focusedElement = this.state.focusedElement;
            var getFocusedGetter = function () { return dxGridCore.getFocusing(tableBodyRows, focusedElement); };
            return (React.createElement(dxReactCore.Plugin, { name: "TableKeyboardNavigationCore" },
                React.createElement(dxReactCore.Action, { name: "setSearchPanelRef", action: this.setSearchPanelRef }),
                focusedRowEnabled &&
                    React.createElement(dxReactCore.Getter, { name: "highlightSelectedRow", value: true }),
                focusedRowEnabled &&
                    React.createElement(dxReactCore.Getter, { name: "focused", computed: getFocusedGetter }),
                React.createElement(dxReactCore.Template, { name: "tableCell" }, function (params) { return (React.createElement(Cell, __assign({}, params, { component: CellPlaceholder$3, tabIndex: 0, updateRefForKeyboardNavigation: _this.updateRef, setFocusedElement: _this.setFocusedElement, focused: dxGridCore.isCellFocused(params.tableRow, params.tableColumn, focusedElement) }))); }),
                React.createElement(dxReactCore.Template, { name: "header" },
                    React.createElement(dxReactCore.TemplatePlaceholder, { params: {
                            updateRefForKeyboardNavigation: this.updateRef,
                            setFocusedElement: this.setFocusedElement,
                        } })),
                React.createElement(dxReactCore.Template, { name: "footer" },
                    React.createElement(dxReactCore.TemplatePlaceholder, { params: {
                            updateRefForKeyboardNavigation: this.updateRef,
                            setFocusedElement: this.setFocusedElement,
                        } })),
                (focusedRowEnabled) && (React.createElement(dxReactCore.Template, { name: "tableRow", predicate: function (_a) {
                        var tableRow = _a.tableRow;
                        return !!dxGridCore.isDataTableRow(tableRow);
                    } }, function (params) { return (React.createElement(Row, __assign({}, params, { component: RowPlaceholder$1, focused: dxGridCore.isRowFocused(params.tableRow, focusedElement === null || focusedElement === void 0 ? void 0 : focusedElement.rowKey) }))); }))));
        };
        return TableKeyboardNavigationCore;
    }(React.PureComponent));
    // tslint:disable-next-line:max-classes-per-file
    var TableKeyboardNavigationBase = /*#__PURE__*/ (function (_super) {
        __extends(TableKeyboardNavigationBase, _super);
        function TableKeyboardNavigationBase() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        TableKeyboardNavigationBase.prototype.render = function () {
            var _this = this;
            return (React.createElement(dxReactCore.Plugin, { name: "TableKeyboardNavigation", dependencies: [
                    { name: 'Table' },
                ] },
                React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                    var tableColumns = _a.tableColumns, tableBodyRows = _a.tableBodyRows, rootRef = _a.rootRef, tableHeaderRows = _a.tableHeaderRows, expandedRowIds = _a.expandedRowIds;
                    var scrollToColumn = _b.scrollToColumn, stopEditCells = _b.stopEditCells, commitChangedRows = _b.commitChangedRows, cancelChangedRows = _b.cancelChangedRows, startEditCells = _b.startEditCells;
                    return rootRef.current ? (React.createElement(TableKeyboardNavigationCore, __assign({ tableColumns: tableColumns, tableBodyRows: tableBodyRows, rootRef: rootRef, tableHeaderRows: dxGridCore.filterHeaderRows(tableHeaderRows), expandedRowIds: expandedRowIds, scrollToColumn: scrollToColumn, inlineEditing: {
                            stopEditCells: stopEditCells,
                            commitChangedRows: commitChangedRows,
                            cancelChangedRows: cancelChangedRows,
                            startEditCells: startEditCells,
                        } }, _this.props))) : null;
                })));
        };
        TableKeyboardNavigationBase.components = {
            cellComponent: 'Cell',
            rowComponent: 'Row',
        };
        return TableKeyboardNavigationBase;
    }(React.PureComponent));
    // tslint:disable-next-line: max-line-length
    var TableKeyboardNavigation = TableKeyboardNavigationBase;

    var getRowStyle = function (_a) {
        var row = _a.row;
        return (row.height !== undefined
            ? ({ height: "".concat(row.height, "px") })
            : undefined);
    };
    var isNumber = function (value) {
        return typeof value === 'number' || !Number.isNaN(Number(value));
    };

    /* globals requestAnimationFrame cancelAnimationFrame */
    var TableLayoutBase = /*#__PURE__*/ (function (_super) {
        __extends(TableLayoutBase, _super);
        function TableLayoutBase(props) {
            var _this = _super.call(this, props) || this;
            _this.savedOffsetWidth = -1;
            _this.raf = -1;
            _this.state = {
                animationState: new Map(),
            };
            _this.animations = new Map();
            _this.savedScrollWidth = {};
            _this.tableRef = React.createRef();
            return _this;
        }
        TableLayoutBase.prototype.componentDidMount = function () {
            if (this.tableRef.current) {
                var forwardedRef = this.props.forwardedRef;
                if (typeof forwardedRef === 'function') {
                    forwardedRef(this.tableRef.current);
                }
                else if (forwardedRef) {
                    forwardedRef.current = this.tableRef.current;
                }
            }
        };
        TableLayoutBase.prototype.componentDidUpdate = function (prevProps) {
            var columns = this.props.columns;
            var prevColumns = prevProps.columns;
            var animationState = this.state.animationState;
            var activeAnimationExists = !dxCore.shallowEqual(columns, prevColumns)
                || !!animationState.size || !!this.animations.size;
            // NOTE: animation should be recomputed only when columns are changed or
            // an active animation is in progress. Otherwise it will be recalculated on
            // each scroll event.
            if (activeAnimationExists) {
                this.processAnimation(prevColumns);
            }
        };
        TableLayoutBase.prototype.processAnimation = function (prevColumns) {
            var columns = this.props.columns;
            var tableWidth = this.getTableWidth(prevColumns, columns);
            this.animations = dxGridCore.getAnimations(prevColumns, columns, tableWidth, this.animations);
            cancelAnimationFrame(this.raf);
            this.raf = requestAnimationFrame(this.processAnimationFrame.bind(this));
        };
        TableLayoutBase.prototype.getTableWidth = function (prevColumns, columns) {
            var _a = this.tableRef.current, offsetWidth = _a.offsetWidth, scrollWidth = _a.scrollWidth;
            var animationState = this.state.animationState;
            var widthChanged = this.savedOffsetWidth !== offsetWidth
                || !this.savedScrollWidth[columns.length];
            var columnCountChanged = columns.length !== prevColumns.length;
            if (columnCountChanged || (widthChanged && !animationState.size)) {
                this.savedScrollWidth = {};
                this.savedScrollWidth[columns.length] = scrollWidth;
                this.savedOffsetWidth = offsetWidth;
            }
            return this.savedScrollWidth[columns.length];
        };
        TableLayoutBase.prototype.getColumns = function () {
            var columns = this.props.columns;
            var animationState = this.state.animationState;
            var result = columns;
            var isFixedWidth = columns
                .filter(function (column) { return column.width === undefined || column.width === 'auto'; })
                .length === 0;
            if (isFixedWidth) {
                // presumably a flex column added here instead of in a getter in the Table plugin
                // to make sure that all manipulations on taleColumns have already done earlier
                result = __spreadArray(__spreadArray([], __read(result), false), [{ key: dxGridCore.TABLE_FLEX_TYPE.toString(), type: dxGridCore.TABLE_FLEX_TYPE }], false);
            }
            if (animationState.size) {
                result = result
                    .map(function (column) { return (animationState.has(column.key)
                    ? __assign(__assign({}, column), { animationState: animationState.get(column.key) }) : column); });
            }
            return result;
        };
        TableLayoutBase.prototype.processAnimationFrame = function () {
            var animationComponentState = this.state.animationState;
            this.animations = dxGridCore.filterActiveAnimations(this.animations);
            if (!this.animations.size) {
                if (animationComponentState.size) {
                    this.setState({ animationState: new Map() });
                }
                return;
            }
            var animationState = dxGridCore.evalAnimations(this.animations);
            this.setState({ animationState: animationState });
        };
        TableLayoutBase.prototype.render = function () {
            var _a = this.props, Layout = _a.layoutComponent, minColumnWidth = _a.minColumnWidth, forwardedRef = _a.forwardedRef, restProps = __rest(_a, ["layoutComponent", "minColumnWidth", "forwardedRef"]);
            var columns = this.getColumns();
            var minWidth = columns
                .map(function (column) { return column.width || (column.type === dxGridCore.TABLE_FLEX_TYPE ? 0 : minColumnWidth); })
                .filter(function (value) { return value !== 'auto' && value !== 0; })
                .map(function (value) { return isNumber(value) ? "".concat(value, "px") : value; })
                .join(' + ');
            return (React.createElement(Layout, __assign({}, restProps, { tableRef: this.tableRef, columns: columns, minWidth: minWidth, minColumnWidth: minColumnWidth })));
        };
        return TableLayoutBase;
    }(React.PureComponent));
    /** @internal */
    var TableLayout = TableLayoutBase;

    var shouldUpdateRow = function (prevProps, nextProps) {
        var prevCells = prevProps.cells, prevRow = prevProps.row;
        var nextCells = nextProps.cells, nextRow = nextProps.row;
        if (prevRow !== nextRow || prevCells.length !== nextCells.length) {
            return false;
        }
        return !nextCells.some(function (nextCell, i) {
            var prevCell = prevCells[i];
            return prevCell.column !== nextCell.column || prevCell.colSpan !== nextCell.colSpan;
        });
    };
    var VirtualRowLayout = React.memo(function (_a) {
        var row = _a.row, cells = _a.cells, Row = _a.rowComponent, Cell = _a.cellComponent, forwardedRef = _a.forwardedRef;
        return (React.createElement(Row, { forwardedRef: forwardedRef, tableRow: row, style: getRowStyle({ row: row }) }, cells.map(function (_a) {
            var column = _a.column, colSpan = _a.colSpan;
            return (React.createElement(Cell, { key: column.key, tableRow: row, tableColumn: column, colSpan: colSpan }));
        })));
    }, shouldUpdateRow);

    // tslint:disable-next-line: max-line-length
    var VirtualTableLayoutBlock = /*#__PURE__*/ (function (_super) {
        __extends(VirtualTableLayoutBlock, _super);
        function VirtualTableLayoutBlock() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        VirtualTableLayoutBlock.prototype.render = function () {
            var _a = this.props, collapsedGrid = _a.collapsedGrid, rowRefsHandler = _a.rowRefsHandler, Body = _a.bodyComponent, cellComponent = _a.cellComponent, rowComponent = _a.rowComponent, isFixed = _a.isFixed;
            return (React.createElement(Body, { isFixed: isFixed }, collapsedGrid.rows.map(function (visibleRow) {
                var row = visibleRow.row, _a = visibleRow.cells, cells = _a === void 0 ? [] : _a;
                return (React.createElement(VirtualRowLayout, { key: row.key, row: row, cells: cells, forwardedRef: function (ref) { return rowRefsHandler(row, ref); }, rowComponent: rowComponent, cellComponent: cellComponent }));
            })));
        };
        return VirtualTableLayoutBlock;
    }(React.PureComponent));

    /** @internal */
    var ColumnGroup = /*#__PURE__*/ (function (_super) {
        __extends(ColumnGroup, _super);
        function ColumnGroup() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        ColumnGroup.prototype.render = function () {
            var columns = this.props.columns;
            return (React.createElement("colgroup", null, columns.map(function (_a) {
                var key = _a.key, width = _a.width;
                var styleWidth = typeof width === 'number' ? "".concat(width, "px") : width;
                return (React.createElement("col", { key: key, style: width !== undefined
                        ? { width: styleWidth }
                        : undefined }));
            })));
        };
        return ColumnGroup;
    }(React.PureComponent));

    var AUTO_HEIGHT = 'auto';
    var MAX_WINDOW_HEIGHT = 10000000;
    var FACTOR = 3;
    var defaultProps$3 = {
        headerRows: [],
        footerRows: [],
        headComponent: function () { return null; },
        footerComponent: function () { return null; },
        tableComponent: function () { return null; },
        containerComponent: React.forwardRef(function () { return null; }),
    };
    /** @internal */
    // tslint:disable-next-line: max-line-length
    var VirtualTableLayout = /*#__PURE__*/ (function (_super) {
        __extends(VirtualTableLayout, _super);
        function VirtualTableLayout(props) {
            var _this = _super.call(this, props) || this;
            _this.rowRefs = new Map();
            _this.registerRowRef = function (row, ref) {
                if (row.type === dxGridCore.TABLE_STUB_TYPE) {
                    return;
                }
                if (ref === null) {
                    _this.rowRefs.delete(row.key);
                }
                else {
                    _this.rowRefs.set(row.key, ref);
                }
            };
            _this.getRowHeight = function (row) {
                var _a;
                if (row) {
                    var realHeight = (_a = _this.rowRefs.get(row.key)) === null || _a === void 0 ? void 0 : _a.getBoundingClientRect().height;
                    return row.height || realHeight || _this.props.estimatedRowHeight;
                }
                return _this.props.estimatedRowHeight;
            };
            _this.onScroll = function (e) {
                var node = e.target;
                if (_this.shouldSkipScrollEvent(e)) {
                    return;
                }
                var viewportTop = node.scrollTop, viewportLeft = node.scrollLeft;
                var _a = _this.state, containerHeight = _a.containerHeight, skipItems = _a.skipItems, prevViewPort = _a.viewportTop;
                var countSkipRows = _this.getCountSkipRows();
                var dif = viewportTop - prevViewPort;
                var pxInPercent = viewportTop / MAX_WINDOW_HEIGHT;
                // on scrolling with touchpad or mouse viewport difference less then FACTOR * container height
                // and skipItems must not recalculated
                var isDif = Math.abs(dif) < FACTOR * containerHeight;
                var top = Math.min(Math.round(pxInPercent * countSkipRows), countSkipRows);
                _this.setState({
                    viewportTop: viewportTop,
                    viewportLeft: viewportLeft,
                    skipItems: isDif ? skipItems : [top, countSkipRows - top],
                });
            };
            _this.handleContainerSizeChange = function (_a) {
                var width = _a.width, height = _a.height;
                _this.setState({
                    containerHeight: height,
                    containerWidth: width,
                });
            };
            _this.state = {
                viewportTop: 0,
                skipItems: [0, 0],
                containerHeight: 600,
                containerWidth: 800,
                viewportLeft: 0,
            };
            _this.getColumnWidthGetter = dxCore.memoize(function (tableColumns, tableWidth, minColumnWidth) { return (dxGridCore.getColumnWidthGetter(tableColumns, tableWidth, minColumnWidth)); });
            return _this;
        }
        VirtualTableLayout.prototype.getCountSkipRows = function () {
            var containerHeight = this.props.totalRowCount * this.props.estimatedRowHeight;
            if (containerHeight > MAX_WINDOW_HEIGHT) {
                return Math.round(this.props.totalRowCount - MAX_WINDOW_HEIGHT /
                    this.props.estimatedRowHeight);
            }
            return 0;
        };
        VirtualTableLayout.prototype.componentDidUpdate = function (prevProps, prevState) {
            var _a = this.props, bodyRows = _a.bodyRows, columns = _a.columns;
            // NOTE: the boundaries depend not only on scroll position and container dimensions
            // but on body rows too. This boundaries update is especially important when
            // lazy loading is used because by the time that all involved events are handled
            // no rows are loaded yet.
            var bodyRowsChanged = prevProps.bodyRows !== bodyRows;
            // Also it's the only place where we can respond to the column count change
            var columnCountChanged = prevProps.columns.length !== columns.length;
            var _b = this.state, viewportTop = _b.viewportTop, viewportLeft = _b.viewportLeft, containerWidth = _b.containerWidth, containerHeight = _b.containerHeight;
            var viewportTopChanged = prevState.viewportTop !== viewportTop;
            var viewportLeftChanged = prevState.viewportLeft !== viewportLeft;
            var containerWidthChanged = prevState.containerWidth !== containerWidth;
            var containerHeightChanged = prevState.containerHeight !== containerHeight;
            if (prevProps.totalRowCount !== this.props.totalRowCount) {
                var countSkipRows = this.getCountSkipRows();
                var skipItems = this.state.skipItems;
                if (countSkipRows !== 0 && skipItems[0] === 0 && skipItems[1] === 0) {
                    this.setState({
                        skipItems: [0, countSkipRows],
                    });
                }
            }
            if (bodyRowsChanged || columnCountChanged || columns[0].width !== undefined &&
                dxGridCore.isColumnsWidthDifferent(prevProps.columns, columns) || viewportTopChanged ||
                viewportLeftChanged || containerWidthChanged || containerHeightChanged) {
                this.updateViewport();
            }
        };
        VirtualTableLayout.prototype.shouldSkipScrollEvent = function (e) {
            var node = e.target;
            // NOTE: prevent nested scroll to update viewport
            if (node !== e.currentTarget) {
                return true;
            }
            // NOTE: normalize position:
            // in Firefox and Chrome (zoom > 100%) when scrolled to the bottom
            // in Edge when scrolled to the right edge
            var correction = 1;
            var nodeHorizontalOffset = parseInt(node.scrollLeft + node.clientWidth, 10) - correction;
            var nodeVerticalOffset = parseInt(node.scrollTop + node.clientHeight, 10) - correction;
            // NOTE: prevent iOS to flicker in bounces and correct rendering on high dpi screens
            if (node.scrollTop < 0
                || node.scrollLeft < 0
                || nodeHorizontalOffset > Math.max(node.scrollWidth, node.clientWidth)
                || nodeVerticalOffset > Math.max(node.scrollHeight, node.clientHeight)) {
                return true;
            }
            return false;
        };
        VirtualTableLayout.prototype.updateViewport = function () {
            var _a = this.props, viewport = _a.viewport, setViewport = _a.setViewport;
            var newViewport = this.calculateViewport();
            if (viewport !== newViewport) {
                setViewport(newViewport);
            }
        };
        VirtualTableLayout.prototype.calculateViewport = function () {
            var _a = this.state, viewportTop = _a.viewportTop, skipItems = _a.skipItems, viewportLeft = _a.viewportLeft, containerHeight = _a.containerHeight, containerWidth = _a.containerWidth;
            var _b = this.props, loadedRowsStart = _b.loadedRowsStart, bodyRows = _b.bodyRows, headerRows = _b.headerRows, footerRows = _b.footerRows, columns = _b.columns, minColumnWidth = _b.minColumnWidth, isDataRemote = _b.isDataRemote, viewport = _b.viewport;
            var getColumnWidth = this.getColumnWidthGetter(columns, containerWidth, minColumnWidth);
            return dxGridCore.getViewport({ viewportTop: viewportTop, skipItems: skipItems, viewportLeft: viewportLeft, containerHeight: containerHeight, containerWidth: containerWidth }, { loadedRowsStart: loadedRowsStart, columns: columns, bodyRows: bodyRows, headerRows: headerRows, footerRows: footerRows, isDataRemote: isDataRemote, viewport: viewport }, this.getRowHeight, getColumnWidth);
        };
        VirtualTableLayout.prototype.getCollapsedGrids = function (viewport) {
            var _a = this.state, containerWidth = _a.containerWidth, viewportLeft = _a.viewportLeft, skipItems = _a.skipItems;
            var _b = this.props, headerRows = _b.headerRows, bodyRows = _b.bodyRows, footerRows = _b.footerRows, columns = _b.columns, loadedRowsStart = _b.loadedRowsStart, totalRowCount = _b.totalRowCount, getCellColSpan = _b.getCellColSpan, minColumnWidth = _b.minColumnWidth;
            var getColumnWidth = this.getColumnWidthGetter(columns, containerWidth, minColumnWidth);
            return dxGridCore.getCollapsedGrids({
                headerRows: headerRows,
                bodyRows: bodyRows,
                footerRows: footerRows,
                columns: columns,
                loadedRowsStart: loadedRowsStart,
                totalRowCount: totalRowCount,
                getCellColSpan: getCellColSpan,
                viewportLeft: viewportLeft,
                containerWidth: containerWidth,
                viewport: viewport,
                skipItems: skipItems,
                getRowHeight: this.getRowHeight,
                getColumnWidth: getColumnWidth,
            });
        };
        VirtualTableLayout.prototype.render = function () {
            var _a = this.props, Container = _a.containerComponent, Table = _a.tableComponent, Head = _a.headComponent, Body = _a.bodyComponent, Footer = _a.footerComponent, tableRef = _a.tableRef, height = _a.height, headerRows = _a.headerRows, footerRows = _a.footerRows, minColumnWidth = _a.minColumnWidth, minWidth = _a.minWidth, cellComponent = _a.cellComponent, rowComponent = _a.rowComponent, viewport = _a.viewport, scrollTop = _a.scrollTop, columns = _a.columns, nextColumnId = _a.nextColumnId;
            var scrollLeft = dxGridCore.getScrollLeft(columns.length, minColumnWidth, nextColumnId);
            var collapsedGrids = this.getCollapsedGrids(viewport);
            var commonProps = {
                cellComponent: cellComponent,
                rowComponent: rowComponent,
                minColumnWidth: minColumnWidth,
                minWidth: minWidth,
                rowRefsHandler: this.registerRowRef,
            };
            var sizerHeight = height === AUTO_HEIGHT ? null : height;
            return (React.createElement(dxReactCore.Sizer, { onSizeChange: this.handleContainerSizeChange, containerComponent: Container, style: { height: sizerHeight }, onScroll: this.onScroll, scrollTop: scrollTop, scrollLeft: scrollLeft },
                React.createElement(Table, { forwardedRef: tableRef, style: {
                        minWidth: "".concat(minWidth, "px"),
                    } },
                    React.createElement(ColumnGroup, { columns: collapsedGrids.bodyGrid.columns }),
                    (!!headerRows.length) && (React.createElement(VirtualTableLayoutBlock, __assign({}, commonProps, { name: "header", isFixed: true, collapsedGrid: collapsedGrids.headerGrid, bodyComponent: Head }))),
                    React.createElement(VirtualTableLayoutBlock, __assign({}, commonProps, { name: "body", collapsedGrid: collapsedGrids.bodyGrid, bodyComponent: Body })),
                    (!!footerRows.length) && (React.createElement(VirtualTableLayoutBlock, __assign({}, commonProps, { name: "footer", isFixed: true, collapsedGrid: collapsedGrids.footerGrid, bodyComponent: Footer }))))));
        };
        VirtualTableLayout.defaultProps = defaultProps$3;
        return VirtualTableLayout;
    }(React.PureComponent));

    var getColumnStyle = function (_a) {
        var column = _a.column;
        return column.animationState;
    };
    /** @internal */
    var RowLayout = React.memo(function (props) {
        var row = props.row, columns = props.columns, Row = props.rowComponent, Cell = props.cellComponent, getCellColSpan = props.getCellColSpan;
        var getColSpan = React.useCallback(function (tableRow, tableColumn) { return getCellColSpan({ tableRow: tableRow, tableColumn: tableColumn, tableColumns: columns }); }, [columns, getCellColSpan]);
        return (React.createElement(Row, { tableRow: row, style: getRowStyle({ row: row }) }, columns
            .map(function (column) { return (React.createElement(Cell, { key: column.key, tableRow: row, tableColumn: column, style: getColumnStyle({ column: column }), colSpan: getColSpan(row, column) })); })));
    });

    /** @internal */
    var RowsBlockLayout = /*#__PURE__*/ (function (_super) {
        __extends(RowsBlockLayout, _super);
        function RowsBlockLayout() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        RowsBlockLayout.prototype.render = function () {
            var _a = this.props, rows = _a.rows, columns = _a.columns, Block = _a.blockComponent, rowComponent = _a.rowComponent, cellComponent = _a.cellComponent, getCellColSpan = _a.getCellColSpan;
            return (React.createElement(Block, null, rows
                .map(function (row) { return (React.createElement(RowLayout, { key: row.key, row: row, columns: columns, rowComponent: rowComponent, cellComponent: cellComponent, getCellColSpan: getCellColSpan })); })));
        };
        return RowsBlockLayout;
    }(React.PureComponent));

    var defaultProps$4 = {
        headerRows: [],
        footerRows: [],
        headComponent: function () { return null; },
        footerComponent: function () { return null; },
    };
    /** @internal */
    var StaticTableLayout = /*#__PURE__*/ (function (_super) {
        __extends(StaticTableLayout, _super);
        function StaticTableLayout() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        StaticTableLayout.prototype.render = function () {
            var _a = this.props, headerRows = _a.headerRows, bodyRows = _a.bodyRows, footerRows = _a.footerRows, columns = _a.columns, minWidth = _a.minWidth, Container = _a.containerComponent, Table = _a.tableComponent, headComponent = _a.headComponent, bodyComponent = _a.bodyComponent, footerComponent = _a.footerComponent, rowComponent = _a.rowComponent, cellComponent = _a.cellComponent, getCellColSpan = _a.getCellColSpan, tableRef = _a.tableRef;
            var commonProps = {
                columns: columns,
                rowComponent: rowComponent,
                cellComponent: cellComponent,
                getCellColSpan: getCellColSpan,
            };
            return (React.createElement(Container, null,
                React.createElement(Table, { forwardedRef: tableRef, style: { minWidth: "calc(".concat(minWidth, ")") } },
                    React.createElement(ColumnGroup, { columns: columns }),
                    !!headerRows.length && (React.createElement(RowsBlockLayout, __assign({ rows: headerRows, blockComponent: headComponent }, commonProps))),
                    React.createElement(RowsBlockLayout, __assign({ rows: bodyRows, blockComponent: bodyComponent }, commonProps)),
                    !!footerRows.length && (React.createElement(RowsBlockLayout, __assign({ rows: footerRows, blockComponent: footerComponent }, commonProps))))));
        };
        StaticTableLayout.defaultProps = defaultProps$4;
        return StaticTableLayout;
    }(React.PureComponent));

    /** @internal */
    var emptyViewport = {
        columns: [[0, 0]],
        rows: [0, 0],
        headerRows: [0, 0],
        footerRows: [0, 0],
        top: 0,
        left: 0,
        width: 800,
        height: 600,
    };
    var tableColumnsComputed = function (_a) {
        var tableColumns = _a.tableColumns;
        return dxGridCore.checkColumnWidths(tableColumns);
    };
    /** @internal */
    var makeVirtualTable = function (Table, _a) {
        var VirtualLayout = _a.VirtualLayout, FixedHeader = _a.FixedHeader, FixedFooter = _a.FixedFooter, SkeletonCell = _a.SkeletonCell, defaultEstimatedRowHeight = _a.defaultEstimatedRowHeight, defaultHeight = _a.defaultHeight;
        var VirtualTable = /*#__PURE__*/ (function (_super) {
            __extends(VirtualTable, _super);
            function VirtualTable(props) {
                var _this = _super.call(this, props) || this;
                _this.setViewport = function (viewport) {
                    _this.setState({ viewport: viewport });
                };
                _this.state = {
                    viewport: emptyViewport,
                    nextRowId: undefined,
                    nextColumnId: undefined,
                };
                _this.scrollToRow = function (nextRowId) { return _this.setState({ nextRowId: nextRowId }); };
                _this.scrollToColumn = function (nextColumnId) { return _this.setState({ nextColumnId: nextColumnId }); };
                return _this;
            }
            VirtualTable.prototype.componentDidUpdate = function (_, prevState) {
                var prevId = prevState.nextRowId, prevColumnId = prevState.nextColumnId;
                var _a = this.state, currentId = _a.nextRowId, currentColumnId = _a.nextColumnId;
                if (currentId !== undefined && currentId === prevId) {
                    this.setState({ nextRowId: undefined });
                }
                if (currentColumnId !== undefined && prevColumnId === currentColumnId) {
                    this.setState({ nextColumnId: undefined });
                }
            };
            VirtualTable.prototype.render = function () {
                var _this = this;
                var _a = this.props, height = _a.height, estimatedRowHeight = _a.estimatedRowHeight, SkeletonStubCell = _a.skeletonCellComponent, children = _a.children, restProps = __rest(_a, ["height", "estimatedRowHeight", "skeletonCellComponent", "children"]);
                var _b = this.state, stateViewport = _b.viewport, nextId = _b.nextRowId, nextColumnId = _b.nextColumnId;
                return (React.createElement(dxReactCore.Plugin, { name: "VirtualTable" },
                    React.createElement(Table, __assign({ layoutComponent: VirtualLayout }, restProps)),
                    React.createElement(dxReactCore.Action, { name: "setViewport", action: this.setViewport }),
                    React.createElement(dxReactCore.Action, { name: "scrollToRow", action: this.scrollToRow }),
                    React.createElement(dxReactCore.Action, { name: "scrollToColumn", action: this.scrollToColumn }),
                    React.createElement(dxReactCore.Getter, { name: "viewport", value: stateViewport }),
                    React.createElement(dxReactCore.Getter, { name: "tableColumns", computed: tableColumnsComputed }),
                    React.createElement(dxReactCore.Template, { name: "tableLayout" }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a, _b) {
                        var availableRowCount = _a.availableRowCount, loadedRowsStart = _a.loadedRowsStart, tableBodyRows = _a.tableBodyRows, isDataRemote = _a.isDataRemote, viewport = _a.viewport;
                        var setViewport = _b.setViewport;
                        var onTopRowChange = _this.props.onTopRowChange;
                        var rowId = dxGridCore.getTopRowId(viewport, tableBodyRows, isDataRemote);
                        onTopRowChange(rowId);
                        var totalRowCount = availableRowCount || tableBodyRows.length;
                        var scrollTop = dxGridCore.getScrollTop(tableBodyRows, totalRowCount, nextId, estimatedRowHeight, isDataRemote);
                        return (React.createElement(dxReactCore.TemplatePlaceholder, { params: __assign(__assign({}, params), { totalRowCount: totalRowCount, loadedRowsStart: loadedRowsStart, isDataRemote: isDataRemote, height: height, estimatedRowHeight: estimatedRowHeight, setViewport: setViewport, viewport: viewport, scrollTop: scrollTop, nextColumnId: nextColumnId }) }));
                    })); }),
                    React.createElement(dxReactCore.Template, { name: "tableCell", predicate: function (_a) {
                            var tableRow = _a.tableRow;
                            return !!dxGridCore.isStubTableCell(tableRow);
                        } }, function (params) { return (React.createElement(dxReactCore.TemplateConnector, null, function (_a) {
                        var isDataRemote = _a.isDataRemote;
                        return (isDataRemote ? React.createElement(SkeletonStubCell, __assign({}, params)) : React.createElement(dxReactCore.TemplatePlaceholder, null));
                    })); })));
            };
            VirtualTable.defaultProps = {
                estimatedRowHeight: defaultEstimatedRowHeight,
                height: defaultHeight,
                skeletonCellComponent: SkeletonCell,
                onTopRowChange: function () { },
            };
            VirtualTable.TOP_POSITION = dxGridCore.TOP_POSITION;
            VirtualTable.BOTTOM_POSITION = dxGridCore.BOTTOM_POSITION;
            return VirtualTable;
        }(React.PureComponent));
        Object.values(Table.components).forEach(function (name) {
            VirtualTable[name] = Table[name];
        });
        VirtualTable.FixedHeader = FixedHeader;
        VirtualTable.FixedFooter = FixedFooter;
        VirtualTable.SkeletonCell = SkeletonCell;
        return VirtualTable;
    };

    var Node = /*#__PURE__*/ (function () {
        function Node(start, rows) {
            this.prev = null;
            this.next = null;
            this.start = start;
            this.rows = rows;
        }
        return Node;
    }());
    // tslint:disable-next-line:max-classes-per-file
    var LRUCache = /*#__PURE__*/ (function () {
        function LRUCache(pageSize, capacity) {
            if (capacity === void 0) { capacity = Number.POSITIVE_INFINITY; }
            this.pages = new Map();
            this.pageSize = pageSize;
            this.capacity = capacity;
            this.initList();
        }
        LRUCache.prototype.initList = function () {
            this.head = new Node(-1, []);
            this.tail = new Node(-1, []);
            this.head.next = this.tail;
            this.tail.prev = this.head;
        };
        LRUCache.prototype.addPage = function (pageStart, rows) {
            if (this.pages.has(pageStart)) {
                this.removePage(pageStart);
            }
            var node = new Node(pageStart, rows);
            var last = this.tail.prev;
            last.next = node;
            node.next = this.tail;
            node.prev = last;
            this.tail.prev = node;
            this.pages.set(pageStart, node);
            if (this.pages.size > this.capacity) {
                this.removePage(this.head.next.start);
            }
        };
        LRUCache.prototype.removePage = function (start) {
            var node = this.pages.get(start);
            node.prev.next = node.next;
            node.next.prev = node.prev;
            this.pages.delete(start);
        };
        LRUCache.prototype.getPage = function (pageStart) {
            if (!this.pages.has(pageStart)) {
                return null;
            }
            var rows = this.pages.get(pageStart).rows;
            this.removePage(pageStart);
            this.addPage(pageStart, rows);
            return rows;
        };
        LRUCache.prototype.clear = function () {
            this.pages.clear();
            this.initList();
        };
        return LRUCache;
    }());
    var createRowCache = function (pageSize, capacity) {
        if (pageSize === void 0) { pageSize = 100; }
        if (capacity === void 0) { capacity = Number.POSITIVE_INFINITY; }
        var cache = new LRUCache(pageSize, capacity / pageSize);
        return {
            getRows: function (skip, take) {
                var result = [];
                var pageCount = Math.ceil(take / pageSize);
                for (var i = 0; i < pageCount; i += 1) {
                    var pageStart = skip + i * pageSize;
                    var chunk = cache.getPage(pageStart);
                    if (chunk !== null) {
                        result = result.concat(chunk);
                    }
                    // yield if last page is incomplete
                    if (chunk === null || (i !== pageCount - 1 && chunk.length !== pageSize)) {
                        return result;
                    }
                }
                return result;
            },
            setRows: function (skip, rows) {
                var pageCount = Math.ceil(rows.length / pageSize);
                for (var i = 0; i < pageCount; i += 1) {
                    var pageStart = i * pageSize;
                    var rowsChunk = rows.slice(pageStart, pageStart + pageSize);
                    // put incomplete page only if it is last one
                    if (rowsChunk.length === pageSize || i === pageCount - 1) {
                        cache.addPage(pageStart + skip, rowsChunk);
                    }
                }
            },
            invalidate: function () { return cache.clear(); },
        };
    };

    var withKeyboardNavigation = function (key1, key2) {
        return function (Component) {
            var ComponentWithNavigation = /*#__PURE__*/ (function (_super) {
                __extends(ComponentWithNavigation, _super);
                function ComponentWithNavigation(props) {
                    var _this = _super.call(this, props) || this;
                    _this.ref = { current: null };
                    _this.handleClick = _this.handleClick.bind(_this);
                    _this.setForwardedRef = _this.setForwardedRef.bind(_this);
                    return _this;
                }
                ComponentWithNavigation.prototype.setForwardedRef = function (node) {
                    var _a, _b;
                    (_a = this.ref.current) === null || _a === void 0 ? void 0 : _a.removeEventListener('mouseup', this.handleClick);
                    this.ref.current = node;
                    (_b = this.ref.current) === null || _b === void 0 ? void 0 : _b.addEventListener('mouseup', this.handleClick);
                };
                ComponentWithNavigation.prototype.componentDidMount = function () {
                    var _a = this.props, updateRefForKeyboardNavigation = _a.updateRefForKeyboardNavigation, tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                    if (this.ref.current && updateRefForKeyboardNavigation) {
                        updateRefForKeyboardNavigation({
                            ref: this.ref,
                            key1: key1 || tableRow.key,
                            key2: key2 || tableColumn.key,
                            action: 'add',
                        });
                    }
                };
                ComponentWithNavigation.prototype.componentWillUnmount = function () {
                    var _a = this.props, updateRefForKeyboardNavigation = _a.updateRefForKeyboardNavigation, tableRow = _a.tableRow, tableColumn = _a.tableColumn;
                    if (this.ref.current && updateRefForKeyboardNavigation) {
                        updateRefForKeyboardNavigation({
                            ref: this.ref,
                            key1: key1 || tableRow.key,
                            key2: key2 || tableColumn.key,
                            action: 'remove',
                        });
                        this.ref.current.removeEventListener('mouseup', this.handleClick);
                    }
                };
                ComponentWithNavigation.prototype.handleClick = function (event) {
                    var _a = this.props, tableRow = _a.tableRow, tableColumn = _a.tableColumn, setFocusedElement = _a.setFocusedElement;
                    if (setFocusedElement) {
                        setFocusedElement({ key1: key1 || tableRow.key, key2: key2 || tableColumn.key, event: event });
                    }
                };
                ComponentWithNavigation.prototype.render = function () {
                    var _a = this.props, setFocusedElement = _a.setFocusedElement, updateRefForKeyboardNavigation = _a.updateRefForKeyboardNavigation, restProps = __rest(_a, ["setFocusedElement", "updateRefForKeyboardNavigation"]);
                    return React.createElement(Component, __assign({ forwardedRef: this.setForwardedRef }, restProps));
                };
                return ComponentWithNavigation;
            }(React.PureComponent));
            return ComponentWithNavigation;
        };
    };

    var InlineSummaryItem = React.memo(function (_a) {
        var _b = _a.summary, messageKey = _b.messageKey, columnTitle = _b.columnTitle, SummaryComponent = _b.component, getMessage = _a.getMessage;
        return (React.createElement(React.Fragment, null,
            getMessage(messageKey, { columnTitle: columnTitle }),
            React.createElement(SummaryComponent, null)));
    });

    exports.ColumnChooser = ColumnChooser;
    exports.CustomGrouping = CustomGrouping;
    exports.CustomPaging = CustomPaging;
    exports.CustomSummary = CustomSummary;
    exports.CustomTreeData = CustomTreeData;
    exports.DataTypeProvider = DataTypeProvider;
    exports.DragDropProvider = DragDropProvider;
    exports.EditingState = EditingState;
    exports.ExportPanel = ExportPanel;
    exports.FilteringState = FilteringState;
    exports.Grid = Grid;
    exports.GroupPanelLayout = GroupPanelLayout;
    exports.GroupingPanel = GroupingPanel;
    exports.GroupingState = GroupingState;
    exports.InlineSummaryItem = InlineSummaryItem;
    exports.IntegratedFiltering = IntegratedFiltering;
    exports.IntegratedGrouping = IntegratedGrouping;
    exports.IntegratedPaging = IntegratedPaging;
    exports.IntegratedSelection = IntegratedSelection;
    exports.IntegratedSorting = IntegratedSorting;
    exports.IntegratedSummary = IntegratedSummary;
    exports.PagingPanel = PagingPanel;
    exports.PagingState = PagingState;
    exports.RowDetailState = RowDetailState;
    exports.SearchPanel = SearchPanel;
    exports.SearchState = SearchState;
    exports.SelectionState = SelectionState;
    exports.SortingState = SortingState;
    exports.StaticTableLayout = StaticTableLayout;
    exports.SummaryState = SummaryState;
    exports.Table = Table;
    exports.TableBandHeader = TableBandHeader;
    exports.TableColumnReordering = TableColumnReordering;
    exports.TableColumnResizing = TableColumnResizing;
    exports.TableColumnVisibility = TableColumnVisibility;
    exports.TableEditColumn = TableEditColumn;
    exports.TableEditRow = TableEditRow;
    exports.TableFilterRow = TableFilterRow;
    exports.TableFixedColumns = TableFixedColumns;
    exports.TableGroupRow = TableGroupRow;
    exports.TableHeaderRow = TableHeaderRow;
    exports.TableInlineCellEditing = TableInlineCellEditing;
    exports.TableKeyboardNavigation = TableKeyboardNavigation;
    exports.TableLayout = TableLayout;
    exports.TableRowDetail = TableRowDetail;
    exports.TableSelection = TableSelection;
    exports.TableSummaryRow = TableSummaryRow;
    exports.TableSummaryRowBase = TableSummaryRowBase;
    exports.TableTreeColumn = TableTreeColumn;
    exports.Toolbar = Toolbar;
    exports.TreeDataState = TreeDataState;
    exports.VirtualTableLayout = VirtualTableLayout;
    exports.VirtualTableState = VirtualTableState;
    exports.createRowCache = createRowCache;
    exports.defaultMessages = defaultMessages$1;
    exports.emptyViewport = emptyViewport;
    exports.makeVirtualTable = makeVirtualTable;
    exports.withKeyboardNavigation = withKeyboardNavigation;

    Object.defineProperty(exports, '__esModule', { value: true });

})));
//# sourceMappingURL=dx-react-grid.umd.cjs.map
