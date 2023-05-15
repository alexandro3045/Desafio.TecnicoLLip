/* eslint-disable import/no-anonymous-default-export */
import React, { useState } from 'react';

import {
  EditingState,
  DataTypeProvider,
  TreeDataState, SortingState, SelectionState, FilteringState, PagingState,
  CustomTreeData, IntegratedFiltering, IntegratedPaging, IntegratedSorting, IntegratedSelection,
} from '@devexpress/dx-react-grid';

import {
  Grid,
  Table, TableHeaderRow, TableFilterRow, TableTreeColumn,
  PagingPanel, TableColumnResizing, Toolbar, TableColumnVisibility, ColumnChooser,
  TableEditColumn,
} from '@devexpress/dx-react-grid-bootstrap4';

import {
  Button, Modal, ModalHeader, ModalBody, ModalFooter,
  Container, Row, Col, Label, FormGroup, Input,
} from 'reactstrap';

import '@devexpress/dx-react-grid-bootstrap4/dist/dx-react-grid-bootstrap4.css';

import {status, tasks, employees, priorities } from '../demo-data/tree-data';

import Icon from "react-edp-icons";

import {
  Plugin, Template, TemplateConnector, TemplatePlaceholder,
} from '@devexpress/dx-react-core';

const arrayEmployer = employees;

const EmployeeFormatter = ({ row }) => (
  <div
    style={{
      display: 'flex',
    }}
  >
    <div
      style={{
        display: 'inline-block',
        background: 'white',
        borderRadius: '3px',
        width: '30px',
        height: '30px',
        margin: '-8px 8px -8px 0',
        textAlign: 'center',
      }}
    >
      <img
        src={`https://js.devexpress.com/Demos/WidgetsGallery/JSDemos/${findEmployees(row.Assigned_Employee_ID)?.Picture}`}
        style={{
          height: '28px',
          margin: '0 auto',
        }}
        alt="Avatar"
      />
    </div>
    {findEmployees(row.Assigned_Employee_ID)?.Name}
  </div>
);

function findEmployees(Assigned_Employee_ID){
 
  const employees = arrayEmployer.find(e => e.ID === Number(Assigned_Employee_ID));

  return employees;
}

const getChildRows = (row, rows) => {
  const childRows = rows.filter(r => r.Parent_ID === (row ? row.ID : 0));
  return childRows.length ? childRows : null;
};

const ExpandButton = ({ expanded, visible, onToggle }) => {
  return (
    <span
      style={{
        paddingRight: "5px",
        display: visible ? "block" : "none"
      }}
      onClick={e => {
        e.stopPropagation();
        onToggle();
      }}
      onKeyDown={e => {
        e.stopPropagation();
        onToggle();
      }}
    >
      <Icon
        icon={!expanded ? "ARROW_RIGHT" : "DOWN"}
        size={15}
        color="#RRGGBB"
      />
    </span>
  );
};

/* eslint-disable no-shadow */
function FieldGroup({ id, label, ...props }) {
  return (
    <FormGroup>
      <Label>{label}</Label>
      <Input {...props} />
    </FormGroup>
  );
}

const getRowId = row => row.ID;


const Popup = ({
  row,
  onChange,
  onApplyChanges,
  onCancelChanges,
  open,
}) => (
  <Modal isOpen={open} onClose={onCancelChanges} aria-labelledby="form-dialog-title">
    <ModalHeader id="form-dialog-title">
      Projects Details
    </ModalHeader>
    <ModalBody>
      <Container>
        <Row>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="Subject"
              label="Subject"
              value={row.Subject}
              onChange={onChange}
            />
          </Col>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="Start_Date"
              label="Start Date"
              value={ new Date(row.Start_Date).toLocaleDateString('pt-BR', {timeZone: 'UTC'})}
              onChange={onChange}
            />
          </Col>          
        </Row>  
        <Row>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="Due_Date"
              label="Due Date"
              value={ new Date(row.Due_Date).toLocaleDateString('pt-BR', {timeZone: 'UTC'})}
              onChange={onChange}              
            />
          </Col>
          <Col>
            <Label for="Status">Status</Label>
            <select
              className="form-control"
              style={{ width: '100%' }}
              name="Status"
              value={row.Status}
              onChange={onChange}
            >
              {status.map(({ ID, Value }) => (
                <option key={ID} value={Value}>
                  {Value}
                </option>
              ))}
            </select>
          </Col>
        </Row>
        <Row>
          <Col> 
            <Label for="Priority">Priorities</Label>
            <select
              className="form-control"
              style={{ width: '100%' }}
              name="Priority"
              value={row.Priority}
              onChange={onChange}
            >
              {priorities.map(({ ID, Value }) => (
                <option key={ID} value={Value}>
                  {Value}
                </option>
              ))}
            </select>
          </Col>
          <Col>
            <Label for="Assigned">Assigned</Label>
            <select
              className="form-control"
              style={{ width: '100%' }}
              name="Assigned_Employee_ID"
              value={row.Assigned_Employee_ID}
              onChange={onChange}
            >
              {employees.map(({ ID, Name }) => (
                <option key={ID} value={ID}>
                  {Name}
                </option>
              ))}
            </select>
          </Col>          
        </Row>      
      </Container>
    </ModalBody>
    <ModalFooter>
      <Button onClick={onCancelChanges} color="secondary">
        Cancel
      </Button>
      {' '}
      <Button onClick={onApplyChanges} color="primary">
        Save
      </Button>
    </ModalFooter>
  </Modal>
);

const PopupEditing = React.memo(({ popupComponent: Popup }) => (
  <Plugin>
    <Template name="popupEditing">
      <TemplateConnector>
        {(
          {
            rows,
            getRowId,
            addedRows,
            editingRowIds,
            createRowChange,
            rowChanges,
          },
          {
            changeRow, changeAddedRow, commitChangedRows, commitAddedRows,
            stopEditRows, cancelAddedRows, cancelChangedRows,
          },
        ) => {
          const isNew = addedRows.length > 0;

          let editedRow;

          let rowId;

          if (isNew) {
            rowId = 0;
            editedRow = addedRows[rowId];
          } else {
            [rowId] = editingRowIds;
            const targetRow = rows.filter(row => getRowId(row) === rowId)[0];
            editedRow = { ...targetRow, ...rowChanges[rowId] };
          }

          const processValueChange = ({ target: { name, value } }) => {
            const changeArgs = {
              rowId,
              change: createRowChange(editedRow, value, name),
            };
            if (isNew) {
              changeAddedRow(changeArgs);
            } else {
              changeRow(changeArgs);
            }
          };

          const rowIds = isNew ? [0] : editingRowIds;
          
          const applyChanges = () => {
            if (isNew) {
              commitAddedRows({ rowIds });
            } else {
              stopEditRows({ rowIds });
              commitChangedRows({ rowIds });
            }
          };

          const cancelChanges = () => {
            if (isNew) {
              cancelAddedRows({ rowIds });
            } else {
              stopEditRows({ rowIds });
              cancelChangedRows({ rowIds });
            }
          };

          const open = editingRowIds.length > 0 || isNew;
          return (
            <Popup
              open={open}
              row={editedRow}
              onChange={processValueChange}
              onApplyChanges={applyChanges}
              onCancelChanges={cancelChanges}
            />
          );

        }}
      </TemplateConnector>
    </Template>
    <Template name="root">
      <TemplatePlaceholder />
      <TemplatePlaceholder name="popupEditing" />
    </Template>
  </Plugin>
));

export default () => {

  const [columns] = useState([
    { name: 'Subject', title: 'Task Subject' },
    { name: 'Assigned_Employee_ID', title: 'Assigned', getCellValue: row => employees.find(e => e.ID === row.Assigned_Employee_ID)?.Name },
    { name: 'Status', title: 'Status', getCellValue: row => status.find(p => p.ID === row.Status)?.Value },
    { name: 'Priority', title: 'Priority', getCellValue: row => priorities.find(p => p.ID === row.Priority).Value },
    { name: 'Completion', title: '% Completed', getCellValue: row => `${row.Completion}%` },
    { name: 'Start_Date', title: 'Start Date' },
    { name: 'Due_Date', title: 'Due Date', getCellValue: row => row.Start_Date.split('T')[0] },
  ]);
  const [rows, setRows] = useState(tasks);
  const [editingRowIds, setEditingRowIds] = useState([]);
  const [pageSizes] = useState([5, 10, 20]);
  const [defaultColumnWidths] = useState([
    { columnName: 'Subject', width: 300 },
    { columnName: 'Assigned_Employee_ID', width: 180 },
    { columnName: 'Status', width: 120 },
    { columnName: 'Priority', width: 100 },
    { columnName: 'Completion', width: 100 },
    { columnName: 'Start_Date', width: 120 },
    { columnName: 'Due_Date', width: 120 },
  ]);
  const [defaultHiddenColumnNames] = useState(['Priority', 'Completion']);
  const [tableColumnExtensions] = useState([
    { columnName: 'Completion', align: 'right' },
  ]);
  const [employeeColumns] = useState(['Assigned_Employee_ID']);
  const commitChanges = ({ added, changed }) => {
    let changedRows;
    if (added) {
      const startingAddedId = rows.length > 0 ? rows[rows.length - 1].id + 1 : 0;
      changedRows = [
        ...rows,
        ...added.map((row, index) => ({
          id: startingAddedId + index,
          ...row,
        })),
      ];
    }
    if (changed) {
      changedRows = rows.map(row => (changed[row.ID] ? { ...row, ...changed[row.ID] } : row));
    }
    setRows(changedRows);
  };

  const toLowerCase = value => String(value).toLowerCase();
  const predicate = (value, filter) => toLowerCase(value)
  .startsWith(toLowerCase(filter.value));

  const [integratedFilteringColumnExtensions] = useState([
    { columnName: 'Status', predicate: predicate }
  ]);

  return (
    <div className="card">

      <Grid
        rows={rows}
        columns={columns}
        getRowId={getRowId}
      >
        
        <DataTypeProvider
          for={employeeColumns}
          formatterComponent={EmployeeFormatter}
        />

        
        <TreeDataState />
        <FilteringState />
        <SortingState />
        <SelectionState />
        <PagingState
          defaultCurrentPage={0}
          defaultPageSize={pageSizes[1]}
        />

        <CustomTreeData
          getChildRows={getChildRows}
        />
        <IntegratedFiltering columnExtensions={integratedFilteringColumnExtensions} />
        <IntegratedSelection />
        <IntegratedSorting />
        <IntegratedPaging />

        <Table
          columnExtensions={tableColumnExtensions}
        />
        <TableColumnVisibility
          defaultHiddenColumnNames={defaultHiddenColumnNames}
        />
        <TableColumnResizing
          defaultColumnWidths={defaultColumnWidths}
        />
        <TableHeaderRow
          showSortingControls
        />
        <TableFilterRow />

        <TableTreeColumn 
          for="Subject" 
          showSelectionControls
          showSelectAll
          expandButtonComponent={ExpandButton}/>
        
        <EditingState
          onCommitChanges={commitChanges}
          editingRowIds={editingRowIds}
          onEditingRowIdsChange={setEditingRowIds}
        />

        <TableEditColumn
          showAddCommand
          showEditCommand
        />
        
        <Toolbar />
        <ColumnChooser />

        <PagingPanel
          pageSizes={pageSizes}
        />

        <PopupEditing popupComponent={Popup} />

      </Grid>
    </div>
  );
};
