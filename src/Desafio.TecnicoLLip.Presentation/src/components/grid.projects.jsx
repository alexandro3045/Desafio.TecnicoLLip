/* eslint-disable import/no-anonymous-default-export */
import React, { useState } from 'react';
import {
  Plugin, Template, TemplateConnector, TemplatePlaceholder,
} from '@devexpress/dx-react-core';
import { EditingState } from '@devexpress/dx-react-grid';
import {
  Grid,
  Table,
  TableHeaderRow,
  TableEditColumn,
} from '@devexpress/dx-react-grid-bootstrap3'
import {
  Button, Modal, ModalHeader, ModalBody, ModalFooter,
  Container, Row, Col, Label, FormGroup, Input,
} from 'reactstrap';
import {
  generateRows,
  employeeValues,
} from '../common/generator';
/* eslint-disable no-shadow */
function FieldGroup({ id, label, ...props }) {
  return (
    <FormGroup>
      <Label>{label}</Label>
      <Input {...props} />
    </FormGroup>
  );
}

const Popup = ({
  row,
  onChange,
  onApplyChanges,
  onCancelChanges,
  open,
}) => (
  <Modal isOpen={open} onClose={onCancelChanges} aria-labelledby="form-dialog-title">
    <ModalHeader id="form-dialog-title">
      Employee Details
    </ModalHeader>
    <ModalBody>
      <Container>
        <Row>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="firstName"
              label="First Name"
              value={row.firstName}
              onChange={onChange}
            />
          </Col>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="lastName"
              label="Last Name"
              value={row.lastName}
              onChange={onChange}
            />
          </Col>
        </Row>
        <Row>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="prefix"
              label="Title"
              value={row.prefix}
              onChange={onChange}
            />
          </Col>
          <Col sm={6} className="px-2">
            <FieldGroup
              type="date"
              name="birthDate"
              label="Birth Date"
              value={row.birthDate}
              onChange={onChange}
            />
          </Col>
        </Row>
        <Row>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="position"
              label="Position"
              value={row.position}
              onChange={onChange}
            />
          </Col>
          <Col sm={6} className="px-2">
            <FieldGroup
              name="phone"
              label="Phone"
              value={row.phone}
              onChange={onChange}
            />
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

const getRowId = row => row.id;
export default () => {
  const [columns] = useState([
    { name: 'firstName', title: 'First Name' },
    { name: 'lastName', title: 'Last Name' },
    { name: 'position', title: 'Position' },
    { name: 'phone', title: 'Phone' },
  ]);
  const [rows, setRows] = useState(generateRows({
    columnValues: { id: ({ index }) => index, ...employeeValues },
    length: 8,
  }));

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
      changedRows = rows.map(row => (changed[row.id] ? { ...row, ...changed[row.id] } : row));
    }
    setRows(changedRows);
  };

  return (
    <div className="card">
      <Grid
        rows={rows}
        columns={columns}
        getRowId={getRowId}
      >
        <EditingState
          onCommitChanges={commitChanges}
        />
        <Table />
        <TableHeaderRow />
        <TableEditColumn
          showAddCommand
          showEditCommand
        />
        <PopupEditing popupComponent={Popup} />
      </Grid>
    </div>
  );
};
